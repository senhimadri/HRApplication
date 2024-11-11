using GlobalIdentityServer.Models;

namespace GlobalIdentityServer.DataTransferObject.Users
{
    public class CreateUserDto
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public UserRole UserRole { get; set; }
    }
}
