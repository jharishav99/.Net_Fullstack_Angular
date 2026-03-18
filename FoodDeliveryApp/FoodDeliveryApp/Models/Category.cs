using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // This links Category to many Foods
        public virtual ICollection<Food>? Foods { get; set; }
    }
}