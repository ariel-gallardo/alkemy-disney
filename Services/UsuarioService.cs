using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Linq;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using alkemy_challenge.Models;

namespace alkemy_challenge.Services
{
    public static class UsuarioService
    {
        private const double EXPIRE_MIN = 10.0;
        private const string SECRET_KEY = "SecretEncodedKey";
        public static string CreateToken(Usuario usuario){

            var byteKey = Encoding.ASCII.GetBytes(SECRET_KEY);
            var tokenHandler = new JwtSecurityTokenHandler();

            var tokenDescriptor = new SecurityTokenDescriptor{
                Subject = new ClaimsIdentity(
                    new Claim[]{
                        new Claim(ClaimTypes.Name, usuario.Nombre),
                        new Claim(ClaimTypes.Role, usuario.Rol),
                    }
                ),
                Expires = DateTime.UtcNow.AddMinutes(EXPIRE_MIN),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(byteKey),
                    SecurityAlgorithms.HmacSha256Signature
                )
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}