using BlogDoEltinho.Dtos.Comment;
using System.ComponentModel.DataAnnotations;

namespace BlogDoEltinho.Dtos.PostDto
{
    public class PostDto
    {
        [Key]
        public int Id { get; set; }

        public string ContentPost { get; set; } = string.Empty;
        public DateTime CreatedOnPost { get; set; } = DateTime.Now;
        public List<CommentDto> Comments { get; set; } = new List<CommentDto>();
    }
}
