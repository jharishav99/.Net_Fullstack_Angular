using Microsoft.EntityFrameworkCore;
namespace latest_project.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) :base(options)
        {
            
        }

        public DbSet<latest_project.Models.Student> Students { get; set; }
    }
}
