using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace mvc_core_project.Models
{
    public class Professor
    {
        [Key]
        public int Id  { get; set; }
        public string? Name { get; set; }
        public int StreamId { get; set; }
        [ForeignKey("StreamId")]
        public Stream? Stream { get; set; }
    }
}
