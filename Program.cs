using EFLibrary.Data;

namespace EFLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new LibraryDbContext();
            var Library = new Library
            {
                Name = "My Library",
                Address = "123 Main St"
            };

            dbContext.Libraries.Add(Library);
            dbContext.SaveChanges();


            List<Book> books = new List<Book>
            {
                new Book
                {
                    Title = "Book 1",
                    Author = "Author 1",
                    Price = 9.99m,
                    Library = Library,
                    BookDetails = new BookDetails
                    {
                        ISBN = "1234567890",
                        PageCount = 200,
                        PublishedYear = 2020
                    }
                },
                new Book
                {
                    Title = "Book 2",
                    Author = "Author 2",
                    Price = 14.99m,
                    Library = Library,
                    BookDetails = new BookDetails
                    {
                        ISBN = "0987654321",
                        PageCount = 300,
                        PublishedYear = 2021
                    }
                },

                  new Book
                {
                    Title = "Book 3",
                    Author = "Author 3",
                    Price = 15.99m,
                    Library = Library,
                    BookDetails = new BookDetails
                    {
                        ISBN = "1111111111",
                        PageCount = 400,
                        PublishedYear = 2022
                    }

                }
            };

            dbContext.Books.AddRange(books);
            dbContext.SaveChanges();


        }
    }
}

