

namespace Struktura_Projektit.Models
{
    public static class BooksManager
    {
        static List<Book> books = new List<Book>
        {
            new Book
            {
                 Author = "Artur Stringa",
                 Price = 1500m,
                 Title = "Analize matematike"
            },
            new Book
            {
                 Author = "Artur Stringa",
                 Price = 40050m,
                 Title = "Analize matematike 2"
            },
            new Book
            {
                 Author = "Artur Stringa",
                 Price = 700m,
                 Title = "Analize matematike 3"
            }
        };

        public static List<Book> GetBooks()
        {
            return books;
        }

        internal static void AddBook(Book book)
        {
            books.Add(book);
        }

        internal static Book? GetById(int id)
        {
            return books.FirstOrDefault(x => x.Id == id);
        }
    }
}
