using Microsoft.EntityFrameworkCore;

namespace KampusLearn_MVC.Models
{
    public class KampusLearnDbContext: DbContext
    {

        public DbSet<Course> Courses { get; set; }

        public DbSet<Batch> Batches { get; set; }

        public DbSet<Trainer> Trainers { get; set; }

        
        public KampusLearnDbContext(DbContextOptions<KampusLearnDbContext> options) : base(options) 
        {

        }
    }
}
