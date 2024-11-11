using GlobalIdentityServer.DataTransferObject.Global;
using GlobalIdentityServer.DataTransferObject.Users;
using GlobalIdentityServer.Models;
using HRApplication.GlobalIdentityServer.Results;

namespace GlobalIdentityServer.Services.UserRegistration;

public interface IUserRegistration
{
    Task<Result> CreateUser(CreateUserDto input);
    Task<Result> UpdateUser(UpdateUserDto input);
    Task<Result> DeleteUser(Guid id);
    Task<UserGetByDto> GetUserById(Guid id);
    Task<GetLandingPagination<UserLandingDataDto>> UsersLandingPagination(UserRole role, string searchText);
}
