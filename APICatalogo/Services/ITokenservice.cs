using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace APICatalogo.Services
{
    public interface ITokenservice
    {
        JwtSecurityToken GenerateAccessToken(IEnumerable<Claim> claims,
                                         IConfiguration _config);
        string GenerateRefreshToken();

        ClaimsPrincipal GetPrincipalFromExpiredToken(string token,
                                                     IConfiguration _config);
    }
}
