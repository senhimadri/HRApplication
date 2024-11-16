using GlobalIdentityServer.DataTransferObject.Users;
using GlobalIdentityServer.IServices;
using GlobalIdentityServer.Models;

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

        app.MapGet("/users", async (string searchText, IUserRegistration userService) =>
        {
            var users = await userService.UsersLandingPagination(searchText);
            return Results.Ok(users);
        });


    }
}
