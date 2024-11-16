namespace GlobalIdentityServer.Models;

public class UserRole : BaseDomain
{
    public Guid UserId { get; set; }
    public Guid RoleId { get; set; }
}
