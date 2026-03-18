using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryApp.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public int FoodId { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }

        // This calculates automatically
        public decimal TotalAmount => Qty * Price;

        public string CustomerId { get; set; }
    }
}