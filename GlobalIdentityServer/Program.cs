using GlobalIdentityServer.Apis;
using GlobalIdentityServer.Extensions;
using GlobalIdentityServer.Models;
using GlobalIdentityServer.Services.UserRegistration;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMongo(builder.Configuration).AddMongoRepository<UserInformation>("TblUserInformation"); 

builder.Services.AddSingleton<IUserRegistration, UserRegistration>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapUserApi();

app.Run();


