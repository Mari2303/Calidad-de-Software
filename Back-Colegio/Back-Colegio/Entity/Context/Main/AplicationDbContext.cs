using Entity.Model.School;
using Microsoft.EntityFrameworkCore;

namespace Entity.Context.Main
{
    public class AplicationDbContext : DbContext
    {
       
        public DbSet<Schools> Schools { get; set; }
        public DbSet<Period> Periods { get; set; }

    
        public DbSet<Student> Students { get; set; }
        public DbSet<Tuition> Tuitions { get; set; }

    
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Hall> Halls { get; set; }

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options ) : base (options)
        {
                    
        }
   
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }


    }
}
