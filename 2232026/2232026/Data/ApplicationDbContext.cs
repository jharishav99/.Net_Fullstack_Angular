using Microsoft.EntityFrameworkCore;
using _2232026.Models;

namespace _2232026.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Party> Parties { get; set; }
    }
}
