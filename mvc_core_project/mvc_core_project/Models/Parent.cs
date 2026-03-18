using System.ComponentModel.DataAnnotations;
namespace mvc_core_project.Models
{
    public class Parent
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
