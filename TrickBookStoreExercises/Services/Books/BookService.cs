using TrickyBookStore.Models;

namespace TrickyBookStore.Services.Books;

internal class BookService : IBookService
{
    public IList<Book> GetBooks(params long[] bookIds)
    {
        var foundBooks = new List<Book>();

        foreach (var bookId in bookIds)
        {
            var searchedBook = Store.Books.Data.FirstOrDefault(data => data.Id == bookId);

            if (searchedBook == null)
            {
                Console.WriteLine($"Book with id {bookId} not found.");
                continue;
            }

            foundBooks.Add(searchedBook);
        }

        return foundBooks;
    }

    public Book? GetBookById(long id)
    {
        var foundBook = Store.Books.Data.FirstOrDefault(data => data.Id == id);

        if (foundBook != null) return foundBook;

        Console.WriteLine($"Book with id {id} not found.");
        return null;
    }
}