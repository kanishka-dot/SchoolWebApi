using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace SchoolWebApi.Models
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Classroom> Classroom { get; set; }

        public DbSet<Teacher> Teacher { get; set; }

        public DbSet<Subject> Subject { get; set; }

       
        // one to many realtionship define
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Subject)
                .HasForeignKey(e => e.TeacherId)
                .IsRequired(false);

            modelBuilder.Entity<Teacher>()
               .HasMany(e => e.Classroom)
               .
               .HasForeignKey(e => e.TeacherId)
               .IsRequired(false);
        }
        */

    }

 


}
