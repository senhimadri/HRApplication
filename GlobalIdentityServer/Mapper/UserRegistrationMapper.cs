using GlobalIdentityServer.DataTransferObject.Users;
using GlobalIdentityServer.Models;

namespace GlobalIdentityServer.Mapper;

public static class UserRegistrationMapper
{
    public static UserInformation MapUserDtoToUserEntity(this CreateUserDto dto)
    {
        return new UserInformation()
        {
            Username = dto.Username,
            PasswordHash = dto.Password,
            Email = dto.Email,
            IsEmailVerified = true,
            IsLocked = false

        };
    }

    public static UserInformation MapWithUserDto(this UserInformation entity, UpdateUserDto dto)
    {
        entity.Username = dto.Username;
        entity.PasswordHash = dto.Password;
        entity.Email = dto.Email;
        return entity;
    }

    public static UserGetByDto MapUserEntityToUserDto(this UserInformation entity)
    {
       return  new UserGetByDto
        {
            Id = entity.Id,
            Username = entity.Username,
            Password = entity.PasswordHash,
            Email = entity.Email
        };
    }
}
