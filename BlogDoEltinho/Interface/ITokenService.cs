using BlogDoEltinho.Models;

namespace BlogDoEltinho.Interface
{
    public interface ITokenService
    {
       public string CreateToken(UserInfo userInfo);
    }
}
