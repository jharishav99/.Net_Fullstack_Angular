using System.ComponentModel.DataAnnotations;

namespace food_delivery.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Cuisine { get; set; } = string.Empty; 

       
        public virtual ICollection<FoodItem> FoodItems { get; set; } = new List<FoodItem>();
    }
}