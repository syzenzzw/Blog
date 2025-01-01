using BlogDoEltinho.Interface;
using BlogDoEltinho.Models;

namespace BlogDoEltinho.Repository
{
    public class PostRepository : IPostRepository
    {
        public Task<List<Post>> GetAllPostsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
