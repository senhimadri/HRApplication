using GlobalIdentityServer.DataTransferObject.Global;
using GlobalIdentityServer.DataTransferObject.Users;
using GlobalIdentityServer.IServices;
using GlobalIdentityServer.Mapper;
using GlobalIdentityServer.Models;
using GlobalIdentityServer.Repository;
using HRApplication.GlobalIdentityServer.Results;

namespace GlobalIdentityServer.Services;

public class UserRegistration : IUserRegistration
{
    public IRepository<UserInformation> _userRepository;

    public UserRegistration(IRepository<UserInformation> _userRepository)
                                        => this._userRepository = _userRepository;

    public async Task<Result> CreateUser(CreateUserDto input)
    {
        var isExistUserName = await _userRepository.IsExist(x => x.Username == input.Username);

        if (isExistUserName)
            Errors.NewError(400, "User Name already exist.");

        var newUser = input.MapUserDtoToUserEntity();

        await _userRepository.CreateAsync(newUser);

        return Result.Success();
    }

    public async Task<Result> DeleteUser(Guid id)
    {
        var existingUser = await _userRepository.GetAsync(id);

        if (existingUser is null)
            return Errors.ContentNotFound;

        existingUser.IsActive = false;

        await _userRepository.UpdateAsync(existingUser);

        return Result.Success();
    }

    public async Task<UserGetByDto> GetUserById(Guid id)
    {
        var userInfo = await _userRepository.GetAsync(id);

        if (userInfo is null)
            return new UserGetByDto();

        return userInfo.MapUserEntityToUserDto();
    }

    public async Task<Result> UpdateUser(UpdateUserDto input)
    {
        var existingUser = await _userRepository.GetAsync(input.Id);

        if (existingUser is null)
            return Errors.ContentNotFound;

        existingUser = existingUser.MapWithUserDto(input);

        await _userRepository.UpdateAsync(existingUser);

        return Result.Success();

    }

    public Task<GetLandingPagination<UserLandingDataDto>> UsersLandingPagination(string searchText)
    {
        throw new NotImplementedException();
    }
}
