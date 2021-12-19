using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace Server.Data
{
    public class AppDBContext : DbContext
    {
        public DbSet<BlogPost> BlogPosts { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            BlogPost[] _blogToSeed = new BlogPost[3];

            for (int i = 1; i < 4; i++)
            {
                _blogToSeed[i - 1] = new BlogPost
                {
                    BlogId = i,
                    Title = $"Test Data {i}",
                    Content = $"Descriprion for test data {i}",
                    Created_At = DateTime.Now,
                    Thumbnail = "./uploads/placeholder.jpg"
                };
            }

            modelBuilder.Entity<BlogPost>().HasData(_blogToSeed);
        }
    }
}