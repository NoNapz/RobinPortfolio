using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace Server.Data
{
    public class AppDBContext : DbContext
    {
        public DbSet<Skill> Skills { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Skill>().HasData(TestSkills());
        }

        private List<Skill> TestSkills()
        {
            return new List<Skill>
                {
                    new Skill { SkillId = 1001, Title = "Test Data One", Content = "Descriprion for test data one", Thumbnail = "./uploads/placeholder.jpg"},
                    new Skill { SkillId = 1002, Title = "Test Data Two", Content = "Descriprion for test data two", Thumbnail = "./uploads/placeholder.jpg"},
                    new Skill { SkillId = 1003, Title = "Test Data Three", Content = "Descriprion for test data three", Thumbnail = "./uploads/placeholder.jpg"}
                };
        }
    }
}