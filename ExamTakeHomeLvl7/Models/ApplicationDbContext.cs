using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ExamTakeHomeLvl7.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("FileName = ./ActivityTracker.db");
        }

        public DbSet<Activity> Activities { get; set; }
    }
}
