using BlogDoEltinho.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogDoEltinho.Data
{
    public class ApplicationDbContext : IdentityDbContext<UserInfo>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option) { }   

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        
    }
}   
