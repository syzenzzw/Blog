using Microsoft.AspNetCore.Identity;

namespace BlogDoEltinho.Models
{
    public class UserInfo : IdentityUser
    {
        public string NomeUsuario { get; set; } = null!;
        public List<Post>? Posts { get; set; }
    }
}
