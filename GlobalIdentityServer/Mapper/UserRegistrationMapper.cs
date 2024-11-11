using GlobalIdentityServer.DataTransferObject.Users;
using GlobalIdentityServer.Models;

namespace GlobalIdentityServer.Mapper;

public static class UserRegistrationMapper
{
    public static TblUserInformation MapUserDtoToUserEntity(this CreateUserDto dto)
    {
        return new TblUserInformation()
        {
            Username = dto.Username,
            PasswordHash = dto.Password,
            UserRole = dto.UserRole,
        };
    }

    public static TblUserInformation MapWithUserDto(this TblUserInformation entity, UpdateUserDto dto)
    {
        entity.Username = dto.Username;
        entity.PasswordHash = dto.Password;
        entity.UserRole = dto.UserRole;
        return entity;
    }
}
