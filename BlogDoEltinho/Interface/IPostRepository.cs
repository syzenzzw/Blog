using BlogDoEltinho.Models;

namespace BlogDoEltinho.Interface
{
    public interface IPostRepository
    {
        Task<List<Post>> GetAllPostsAsync();
    }
}
