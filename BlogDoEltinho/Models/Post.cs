using System.ComponentModel.DataAnnotations;

namespace BlogDoEltinho.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        public string ContentBlog { get; set; } = string.Empty;
        public DateTime CreatedOnBlog { get; set; } = DateTime.Now;
        public User User { get; set; } = null!;
        public int UserId { get; set; }
    }

    
}
