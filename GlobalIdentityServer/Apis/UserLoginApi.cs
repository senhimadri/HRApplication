using GlobalIdentityServer.DataTransferObject.UserLogin;
using GlobalIdentityServer.IServices;

namespace GlobalIdentityServer.Apis;

public static class UserLoginApi
{
    public static void MapUserLoginApi(this WebApplication app)
    {
        app.MapPost("/userLogin", async (LoginDto input, IUserLogin userLoginService) =>
        {
            var result   = await userLoginService.LoginUser(input);
            return result is not null ? Results.Ok(result) : Results.NotFound();
        });
    }
}
