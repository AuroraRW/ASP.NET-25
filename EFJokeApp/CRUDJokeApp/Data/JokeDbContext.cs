using CRUDJokeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDJokeApp.Data
{
    public class JokeDbContext:DbContext
    {
        public JokeDbContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Joke> Jokes { get; set; }
    }
}
