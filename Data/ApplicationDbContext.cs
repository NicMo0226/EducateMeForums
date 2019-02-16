using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EducateMeForums.Models;

namespace EducateMeForums.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>    {        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)            : base(options)        {        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Forum> Forums { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostReply> PostReplies { get; set; }
        public DbSet<Demographic> Demographics { get; set; }
          public DbSet<WallPost> WallPosts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
     
    }
}
