using System.ComponentModel.DataAnnotations;

namespace BlogDoEltinho.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        public string ContentComment { get; set; } = string.Empty;
        public DateTime CreatedOnComment { get; set; }
        public Post? Post { get; set; }
        public int PostId { get; set; }
    }
}
