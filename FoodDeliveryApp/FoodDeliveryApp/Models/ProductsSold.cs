using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryApp.Models
{
    public class ProductsSold
    {
        [Key]
        public int ProductId { get; set; } // This is the ID for this record
        public int SaleId { get; set; }    // Links to SaleId in Sale class
        public int Qty { get; set; }
        public decimal TotalProductAmount { get; set; }
        public string Status { get; set; }
    }
}