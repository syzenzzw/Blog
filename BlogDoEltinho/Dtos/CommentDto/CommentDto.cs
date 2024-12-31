using BlogDoEltinho.Models;
using System.ComponentModel.DataAnnotations;

namespace BlogDoEltinho.Dtos.Comment
{
    public class CommentDto
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreatedOnComment { get; set; } = DateTime.Now;
        public Post? Post { get; set; }
        public int PostId { get; set; }
    }
}
