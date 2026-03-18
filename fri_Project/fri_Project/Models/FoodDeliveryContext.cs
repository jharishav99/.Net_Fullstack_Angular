using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;

namespace fri_Project.Models
{
  
    public class FoodDeliveryContext :DbContext
    {
        public FoodDeliveryContext(DbContextOptions<FoodDeliveryContext> options):base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }

}
