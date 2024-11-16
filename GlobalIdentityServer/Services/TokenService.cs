using GlobalIdentityServer.IServices;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace GlobalIdentityServer.Services;

public class TokenService : ITokenService
{
    public string GetUserToken(Claim[] claims, JwtSettings jwtSettings, TimeSpan validity)
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SecretKey));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);


        var token = new JwtSecurityToken(
                            issuer: jwtSettings.Issuer,
                            audience: jwtSettings.Audience,
                            claims: claims,
                            expires: DateTime.UtcNow.Add(validity),
                            signingCredentials: credentials
                            );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}

