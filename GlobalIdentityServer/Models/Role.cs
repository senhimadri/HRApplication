namespace GlobalIdentityServer.Models;

public class Role  : BaseDomain
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<RolePermision>? RolePermisions { get; set; }
}
