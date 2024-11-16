using GlobalIdentityServer.Apis;
using GlobalIdentityServer.Extensions;
using GlobalIdentityServer.IServices;
using GlobalIdentityServer.Models;
using GlobalIdentityServer.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMongo(builder.Configuration).AddMongoRepository<UserInformation>("TblUserInformation"); 

builder.Services.AddSingleton<IUserRegistration, UserRegistration>();
builder.Services.AddSingleton<IUserLogin, UserLogin>();
builder.Services.AddSingleton<ITokenService, TokenService>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapUserApi();
app.MapUserLoginApi();

app.Run();


