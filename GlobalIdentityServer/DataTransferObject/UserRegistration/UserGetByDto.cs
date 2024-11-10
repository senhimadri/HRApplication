using GlobalIdentityServer.Models;

namespace GlobalIdentityServer.DataTransferObject.Users;

public class UserGetByDto
{
    public Guid Id { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public UserRole UserRole { get; set; }
    public string? UserRoleName { get; set; }
}
