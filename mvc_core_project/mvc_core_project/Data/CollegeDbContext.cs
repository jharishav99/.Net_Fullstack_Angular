using Microsoft.EntityFrameworkCore;
using mvc_core_project.Models;

namespace mvc_core_project.Data
{
    public class CollegeDbContext : DbContext
    {
        public CollegeDbContext(DbContextOptions<CollegeDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<mvc_core_project.Models.Stream> Streams { get; set; }
    }
}