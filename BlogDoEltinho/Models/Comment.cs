using System.ComponentModel.DataAnnotations;

namespace BlogDoEltinho.Models
{
    public class Comment
    {
        [Key]
        public int IdComment { get; set; }

        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOnComment { get; set; }
    }
}
