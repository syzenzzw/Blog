using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BlogDoEltinho.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Email { get; set; } = string.Empty;
        public string NameUser { get; set; } = string.Empty;
        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}
