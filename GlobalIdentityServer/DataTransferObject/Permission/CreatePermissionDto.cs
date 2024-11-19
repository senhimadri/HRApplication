namespace GlobalIdentityServer.DataTransferObject.Permission;

public class CreatePermissionDto
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<ApiRouteDto>? ApiRoutes { get; set; }
}

public class UpdatePermissionDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<ApiRouteDto>? ApiRoutes { get; set; }
}


public class PermissionGetByIdDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<ApiRouteDto>? ApiRoutes { get; set; }
}

public class PermissionLandingDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}

public class ApiRouteDto
{
    public string? Method { get; set; }
    public string? Route { get; set; }
}