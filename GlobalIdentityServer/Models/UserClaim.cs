namespace GlobalIdentityServer.Models;

public  class UserClaim : BaseDomain
{
    public Guid UserId { get; set; }
    public string? ClaimType { get; set; }
    public string? ClaimValue { get; set; }

}
