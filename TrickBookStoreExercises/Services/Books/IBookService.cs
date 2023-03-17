using TrickBookStoreExercises.Models;

// KeepIt
namespace TrickBookStoreExercises.Services.Books;

public interface IBookService
{
    IList<Book> GetBooks(params long[] ids);
    Book? GetBookById(long id);
}