using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("categ")]
        public int Categid { get; set; }
        public Category categ { get; set; }
    }
}
