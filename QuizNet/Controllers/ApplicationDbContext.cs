using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using QuizNet.Data.Configurations;
using QuizNet.Models.Entities;
using System.Reflection.Emit;
using System.Reflection.Metadata;


namespace QuizNet.Controllers
{
    public class ApplicationDbContext : DbContext
    {
        // DbSet
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Question> Questions { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseNpgsql(connectionString);

        }

        #region Required
        protected override void OnModelCreating(ModelBuilder mb)
        {

            new TopicConfiguration().Configure(mb.Entity<Topic>());
            new QuestionConfiguration().Configure(mb.Entity<Question>());
            
            
            // Apply all in assembly
            // modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlogEntityTypeConfiguration).Assembly);
        } 
        #endregion
    }
}
