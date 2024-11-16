namespace GlobalIdentityServer.Models;

public class RolePermision : BaseDomain
{
    public Guid RoleId { get; set; }
    public Guid PermissionId { get; set; }

}
