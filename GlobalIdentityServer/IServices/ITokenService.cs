using GlobalIdentityServer.DataTransferObject.Token;
using GlobalIdentityServer.Services;
using System.Security.Claims;

namespace GlobalIdentityServer.IServices;

public interface ITokenService
{
    string GetUserToken(Claim[] claims, JwtSettings jwtSettings, TimeSpan validity);
}
