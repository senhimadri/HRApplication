namespace GlobalIdentityServer.Models;

public class Token : BaseDomain
{
    public Guid UserId { get; set; }
    public string? TokenString { get; set; }
    public DateTimeOffset? Expiration { get; set; }
    public bool IsRevoked { get; set; }
}
