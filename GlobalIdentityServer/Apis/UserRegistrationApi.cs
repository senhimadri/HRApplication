using GlobalIdentityServer.DataTransferObject.Users;
using GlobalIdentityServer.Models;
using GlobalIdentityServer.Services.UserRegistration;

namespace GlobalIdentityServer.Apis;

public static class UserRegistrationApi
{
    public static void MapUserApi(this WebApplication app)
    {
        app.MapPost("/userRegistration", async (CreateUserDto input, IUserRegistration userService)=>
        {
            var result = await userService.CreateUser(input);
            return result.IsSuccess ? Results.Ok() : Results.BadRequest(result.Error);
        });

        app.MapPut("/userRegistration", async (UpdateUserDto input, IUserRegistration userService) =>
        {
            var result = await userService.UpdateUser(input);
            return result.IsSuccess ? Results.Ok() : Results.BadRequest(result.Error);
        });

        app.MapDelete("/userRegistration/{id}", async(Guid id, IUserRegistration userService) =>
        {
            var result = await userService.DeleteUser(id);
            return result.IsSuccess ? Results.Ok() : Results.BadRequest(result.Error);
        });

        app.MapGet("/userRegistration/{id}", async (Guid id, IUserRegistration userService) =>
        {
            var user = await userService.GetUserById(id);
            return user is not null ? Results.Ok(user) : Results.NotFound();
        });

        app.MapGet("/users", async (UserRole role, string searchText, IUserRegistration userService) =>
        {
            var users = await userService.UsersLandingPagination(role, searchText);
            return Results.Ok(users);
        });


    }
}
