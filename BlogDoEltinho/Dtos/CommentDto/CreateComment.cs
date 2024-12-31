namespace BlogDoEltinho.Dtos.Comment
{
    public class CreateComment
    {
        public string ContentComment { get; set; } = string.Empty;
        public DateTime CreatedOnComment { get; set; } = DateTime.Now;
    }
}
