namespace GlobalIdentityServer.Services;

public class JwtSettings
{
    public string Issuer { get; set; } = "YourIssuer";
    public string Audience { get; set; } = "YourAudience";
    public string SecretKey { get; set; } = "YourSecretKey_1234567890"; // Use a secure, long key
}

