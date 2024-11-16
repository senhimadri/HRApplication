namespace GlobalIdentityServer.Models;

public class UserInformation : BaseDomain
{
    public string? Username { get; set; }
    public string? PasswordHash { get; set; }

    public string? Email { get; set; }
    public bool IsEmailVerified { get; set; }

    public bool IsLocked { get; set; }
    public List<UserRole>? UserRoles { get; set; }

    public List<UserClaim>? UserClaims { get; set; }
}
