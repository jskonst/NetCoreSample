namespace HelloWorld.Controllers
{
    using System.Linq;
    using HelloWorld.Models;
    using Microsoft.AspNetCore.Mvc;

    public class BooksController : Controller
    {
        private BooksContext db;

        public BooksController(BooksContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Books()
        {
            return View(db.Books.ToList());
        }

    }
}