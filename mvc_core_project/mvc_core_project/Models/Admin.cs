using System.ComponentModel.DataAnnotations;
namespace mvc_core_project.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
