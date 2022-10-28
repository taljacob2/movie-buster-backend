using Microsoft.EntityFrameworkCore;

namespace movie_buster.Data
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions<MainContext> opt) : base(opt)
        {
        }

        // public DbSet<Movies> Movies { get; set; }
        // public DbSet<Tickets> Tickets { get; set; }
    }
}
