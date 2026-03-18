using Microsoft.AspNetCore.Mvc;
using MyFirstWebAPI.Models;

namespace MyFirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // In-memory list (temporary database)
        private static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Rishav", Age = 23 },
            new Student { Id = 2, Name = "Aman", Age = 22 }
        };

        // GET: api/student
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(students);
        }

        // GET: api/student/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound("Student not found");

            return Ok(student);
        }

        // POST: api/student
        [HttpPost]
        public IActionResult Create(Student newStudent)
        {
            students.Add(newStudent);
            return Ok("Student added successfully");
        }

        // PUT: api/student/1
        [HttpPut("{id}")]
        public IActionResult Update(int id, Student updatedStudent)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound("Student not found");

            student.Name = updatedStudent.Name;
            student.Age = updatedStudent.Age;

            return Ok("Student updated successfully");
        }

        // DELETE: api/student/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound("Student not found");

            students.Remove(student);

            return Ok("Student deleted successfully");
        }
    }
}
