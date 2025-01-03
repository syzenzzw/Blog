using BlogDoEltinho.Models;

namespace BlogDoEltinho.Interface
{
    public interface ITokenService
    {
        string CreateToken(UserInfo userInfo);
    }
}
