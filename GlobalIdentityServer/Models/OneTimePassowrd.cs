namespace GlobalIdentityServer.Models;

public class OneTimePassowrd : BaseDomain
{
    public Guid UserId { get; set; }
    public string? Code { get; set; }
    public DateTimeOffset Expiration { get; set; }
    public bool IsUsed { get; set; }
}
