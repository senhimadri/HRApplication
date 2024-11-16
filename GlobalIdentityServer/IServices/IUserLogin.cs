using GlobalIdentityServer.DataTransferObject.UserLogin;
using HRApplication.GlobalIdentityServer.Results;

namespace GlobalIdentityServer.IServices;


public interface IUserLogin
{
    Task<string> LoginUser(LoginDto input);
    Task LogOut(Guid UserId);
}
