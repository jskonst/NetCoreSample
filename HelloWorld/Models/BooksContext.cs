namespace HelloWorld.Models
{
    using Microsoft.EntityFrameworkCore;

    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options)
    : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

    }
}