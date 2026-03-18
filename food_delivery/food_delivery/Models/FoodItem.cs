using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace food_delivery.Models
{
    public class FoodItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ItemName { get; set; } = string.Empty;
        public decimal Price { get; set; }

        // Link to the Restaurant
        public int RestaurantId { get; set; }
        [ForeignKey("RestaurantId")]
        public virtual Restaurant? Restaurant { get; set; }
    }
}