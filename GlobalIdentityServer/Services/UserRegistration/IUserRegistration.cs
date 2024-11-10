using GlobalIdentityServer.DataTransferObject.Users;
using HRApplication.GlobalIdentityServer.Results;

namespace GlobalIdentityServer.Services.UserRegistration;

public interface IUserRegistration
{
    Task<Result> CreateUser(CreateUserDto input);
    Task<Result> UpdateUser(UpdateUserDto input);
    Task<Result> DeleteUser(Guid id);
}
