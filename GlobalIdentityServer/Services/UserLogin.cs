using GlobalIdentityServer.DataTransferObject.UserLogin;
using GlobalIdentityServer.IServices;
using GlobalIdentityServer.Models;
using GlobalIdentityServer.Repository;
using System.Security.Claims;

namespace GlobalIdentityServer.Services;

public class UserLogin(IRepository<UserInformation> _userInformation, 
                       ITokenService _tokenServices) : IUserLogin
{
    private readonly IRepository<UserInformation> userInformation = _userInformation;
    private readonly ITokenService tokenServices = _tokenServices;

    public async Task<string> LoginUser(LoginDto input)
    {
        if (!IsNullorEmptyOutput(input))
            throw new Exception();

        var user =await userInformation
                    .GetAsync(x => x.Username == input.UserName && x.PasswordHash == input.Password);

        if (user is null)
            throw new Exception();

        var userClaim = GetClaimFromUserInformation(user);

        var jwtSettings = GetJwtSettings();

        return tokenServices.GetUserToken(claims: userClaim, jwtSettings , TimeSpan.FromHours(1));
    }

    private JwtSettings GetJwtSettings()
    {
        return new JwtSettings
        {
            Issuer = "MyApp",
            Audience = "MyAppUsers",
            SecretKey = "SuperdfsafnafalkfdalkfjawifjalkdnfalkdfnalknaolfhnwlkfdnaslkdfnqwolfhQLKJDFNLKJASDSecureKey1234567890"
        };
    }

    public Claim[] GetClaimFromUserInformation(UserInformation user)
    {
        return  new[]
        {
            new Claim("UserId", user.Id.ToString()),
            new Claim("UserName", user.Username ?? string.Empty),
            new Claim("Email", user.Email?? string.Empty)
        };
    }

    public bool IsNullorEmptyOutput(LoginDto input)
    {
        if (string.IsNullOrEmpty(input.UserName) && string.IsNullOrEmpty(input.Password))
            return false;

        return true;
    }

    public Task LogOut(Guid UserId)
    {
        throw new NotImplementedException();
    }
}
