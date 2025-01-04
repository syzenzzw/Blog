using BlogDoEltinho.Interface;
using BlogDoEltinho.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BlogDoEltinho.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _config;
        
        public TokenService(IConfiguration config)
        {
            _config = config;
        }
        public string CreateToken(UserInfo userInfo)
        {
            var key = Encoding.UTF8.GetBytes(_config["JWT:Key"]!);
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Email, userInfo.Email!),
                new Claim(JwtRegisteredClaimNames.Name, userInfo.UserName!)
            };

            var signInCredentials =  new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature);

            var tokenConfig = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(3),
                SigningCredentials = signInCredentials,
                Issuer = _config["JWT:Issuer"],
                Audience = _config["JWT:Audience"]
            };

            var handler = new JwtSecurityTokenHandler();
            var tokenGenerate = handler.CreateToken(tokenConfig);

            return handler.WriteToken(tokenGenerate);   
        }
    }
}
