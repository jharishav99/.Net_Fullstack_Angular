using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace mvc_core_project.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        public string? name { get; set; }
        public int  StreamId{ get; set; }
        [ForeignKey("StreamId")]
        public Stream? Stream{ get; set; }
        public int ParentId{ get; set; }
        [ForeignKey("ParentId")]
        public Parent? Parent{ get; set; }
    }
}
