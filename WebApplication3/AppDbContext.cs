using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Person>? People { get; set; }
    }
}
