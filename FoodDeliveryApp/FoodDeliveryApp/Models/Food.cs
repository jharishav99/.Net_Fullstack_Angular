using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDeliveryApp.Models
{
    public class Food
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Category")]
        public int CategId { get; set; } // Your Foreign Key

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        // Navigation property
        public virtual Category? Category { get; set; }
    }
}