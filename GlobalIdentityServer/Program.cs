using GlobalIdentityServer;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<MongoDbSettings>(
    builder.Configuration.GetSection("MongoDbSettings"));


builder.Services.AddSingleton<IMongoClient>(s =>
{
    var mongoSettings = s.GetRequiredService<IOptions<MongoDbSettings>>().Value;
    var connectionString = $"mongodb://{mongoSettings.Username}:{mongoSettings.Password}@{mongoSettings.Host}:{mongoSettings.Port}/?authSource=admin";
    return new MongoClient(connectionString);
});

builder.Services.AddSingleton<MongoDBContext>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


// Define minimal API endpoints

app.MapGet("/api/users", async (MongoDBContext context) =>
{
    var users = await context.Users.Find(_ => true).ToListAsync();
    return Results.Ok(users);
});

app.MapGet("/api/users/{id}", async (string id, MongoDBContext context) =>
{
    var user = await context.Users.Find(u => u.Id == id).FirstOrDefaultAsync();
    return user is not null ? Results.Ok(user) : Results.NotFound();
});

app.MapPost("/api/users", async (User user, MongoDBContext context) =>
{
    await context.Users.InsertOneAsync(user);
    return Results.Created($"/api/users/{user.Id}", user);
});

app.MapPut("/api/users/{id}", async (string id, User updatedUser, MongoDBContext context) =>
{
    var existingUser = await context.Users.Find(u => u.Id == id).FirstOrDefaultAsync();
    if (existingUser is null) return Results.NotFound();

    updatedUser.Id = id; // Ensure the ID remains the same
    await context.Users.ReplaceOneAsync(u => u.Id == id, updatedUser);
    return Results.NoContent();
});

app.MapDelete("/api/users/{id}", async (string id, MongoDBContext context) =>
{
    var user = await context.Users.Find(u => u.Id == id).FirstOrDefaultAsync();
    if (user is null) return Results.NotFound();

    await context.Users.DeleteOneAsync(u => u.Id == id);
    return Results.NoContent();
});



app.Run();


