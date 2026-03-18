using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using v8_web_api.Models;

namespace v8_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private static List<Book> books = new List<Book>
    {
        new Book { Id = 1, Title = "C# for Beginners", Author = "John Doe" },
        new Book { Id = 2, Title = "ASP.NET Magic", Author = "Jane Smith" }
    };

        [HttpGet]
        public ActionResult<List<Book>> GetAllBooks()
        {
            return Ok(books);
        }
    }
}