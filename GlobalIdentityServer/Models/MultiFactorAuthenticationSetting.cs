namespace GlobalIdentityServer.Models;

public class MultiFactorAuthenticationSetting : BaseDomain
{
    public Guid UserId { get; set; }
    public string? Method { get; set; } // e.g., "Email", "SMS", "AuthenticatorApp"
    public string? SecretKey { get; set; } // For TOTP
    public bool IsEnabled { get; set; }

}
