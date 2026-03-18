using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Medicine
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [ForeignKey("pharma")]
        public int PharmacyId { get; set; }
        public Pharmacy? pharma { get; set; } 

        public int Qty { get; set; }
    }
}