namespace GlobalIdentityServer.DataTransferObject.Users;

public class UserLandingDataDto
{
    public Guid Id { get; set; }
    public string? Username { get; set; }
    public string? UserRoleName { get; set; }
}
