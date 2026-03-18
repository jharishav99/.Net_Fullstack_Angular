using System.ComponentModel.DataAnnotations.Schema;

namespace web_api.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [ForeignKey("dept")]
        public int DeptId { get; set; }
        public Department? dept { get; set; }

    }
}
