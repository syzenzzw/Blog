using Microsoft.AspNetCore.Identity;

namespace BlogDoEltinho.Models
{
    public class UserInfo : IdentityUser
    {
        public List<Post>? Posts { get; set; }
    }
}
