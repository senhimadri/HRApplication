namespace HRApplication.Identity.Domain;

public class UserInfo  : BaseEntity
{
    public string? UserName { get; set; }
    public string? PasswordHash { get; set; }

}

