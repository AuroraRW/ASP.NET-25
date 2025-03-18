using Microsoft.EntityFrameworkCore;
using SchoolApp.Models;
namespace SchoolApp.Data
{
    public class SchoolDbContext:DbContext
    {
        public SchoolDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<User> User { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Classroom> Classroom { get; set; }
        public DbSet<Class> Class { get; set; }

    }
}
