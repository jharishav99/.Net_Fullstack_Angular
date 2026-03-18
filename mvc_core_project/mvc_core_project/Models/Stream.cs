using System.ComponentModel.DataAnnotations;
namespace mvc_core_project.Models
{
    public class Stream
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
