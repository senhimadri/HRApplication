using GlobalIdentityServer.Models;

namespace GlobalIdentityServer.DataTransferObject.Users;

public class UpdateUserDto
{
    public Guid Id { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }
}
