using System.Collections.Generic;
using System.Linq;
using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    
    // [Route("api/[controller]")]
    [Route("api/books")]
    public class BooksApiController : Controller
    {
        private BooksContext db;

        public BooksApiController(BooksContext context)
        {
            db = context;
        }

        // GET api/books
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return db.Books.ToList();    
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Book book = db.Books.FirstOrDefault(x => x.Id == id);
            if (book == null)
                return NotFound();
            return new ObjectResult(book);
        }

    }
}