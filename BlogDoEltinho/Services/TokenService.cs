using BlogDoEltinho.Interface;
using BlogDoEltinho.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace BlogDoEltinho.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;
        private readonly SymmetricSecurityKey _key;
        private readonly SecurityTokenDescriptor _tokenDescriptor;
        public TokenService(IConfiguration configuration, SecurityTokenDescriptor tokenDescriptor, SymmetricSecurityKey key)
        {
            _configuration = configuration;
            _tokenDescriptor = tokenDescriptor;
            _key = key;
        }
        public string CreateToken(UserInfo userInfo)
        {
            return null!;
        }
    }
}
