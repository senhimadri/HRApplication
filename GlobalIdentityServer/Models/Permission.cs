namespace GlobalIdentityServer.Models;

public class Permission  : BaseDomain
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<ApiRoute>? ApiRoutes { get; set; }
}

public class ApiRoute : BaseDomain
{
    public string? Method { get; set; } // e.g., GET, POST, PUT, DELETE
    public string? Route { get; set; }
}
