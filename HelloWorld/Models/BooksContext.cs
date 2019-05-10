using Microsoft.EntityFrameworkCore;
namespace HelloWorld.Models
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options): base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Book> Books { get; set; }

    }
}