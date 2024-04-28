using Microsoft.EntityFrameworkCore;
using UserGeneratorApp.Models;

namespace UserGeneratorApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        DbSet<User> Users { get; set; }
    }
}
