namespace GlobalIdentityServer.DataTransferObject.Role;

public class CreateRoleDto
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<RolePermissionDto>? RolePermissions { get; set; }
}

public class UpdateRoleDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<RolePermissionDto>? RolePermissions { get; set; }
}

public class RolePermissionDto
{
    public Guid PermissionId { get; set; }
    public string? PermissionName { get; set; }
}

public class RoleGetByIdDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<RolePermissionDto>? RolePermissions { get; set; }
}

public class RoleLandingDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }

}
