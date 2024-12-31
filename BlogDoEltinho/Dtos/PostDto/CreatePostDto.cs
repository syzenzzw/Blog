namespace BlogDoEltinho.Dtos.PostDto
{
    public class CreatePostDto
    {
        public string ContentPost { get; set; } = string.Empty;
        public DateTime CreatedOnPost { get; set; } = DateTime.Now;
    }
}
