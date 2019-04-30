namespace HelloWorld.Models
{
    using System;
    using System.Linq;
    using Microsoft.Extensions.DependencyInjection;

    public static class SampleData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<BooksContext>();
            if (context.Books.Count() == 0)
            {
                context.Books.AddRange(
                                    new Book
                                    {
                                        Id = 1,
                                        Name = "War and peace",
                                        Author = "Tolstoy ",
                                        Price = 600,
                                    },
                                    new Book
                                    {
                                        Id = 2,
                                        Name = "Clean code",
                                        Author = "Joel Spolsky",
                                        Price = 550,
                                    },
                                    new Book
                                    {
                                        Id = 3,
                                        Name = "C#",
                                        Author = "Troellson",
                                        Price = 500,
                                    });
                context.SaveChanges();
            }
        }
    }
}