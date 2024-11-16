namespace GlobalIdentityServer.Models;

public class AuditLog : BaseDomain
{
    public Guid UserId { get; set; }
    public string? Action { get; set; }
    public string? IpAddress { get; set; }
}