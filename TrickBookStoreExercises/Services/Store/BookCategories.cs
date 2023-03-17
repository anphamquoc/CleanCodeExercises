using TrickBookStoreExercises.Models;

namespace TrickBookStoreExercises.Services.Store;

public static class BookCategories
{
    public static readonly IEnumerable<BookCategory> Data = new List<BookCategory>
    {
        new()
        {
            Id = 1,
            Title = "Programming"
        },
        new()
        {
            Id = 2,
            Title = "Cooking"
        },
        new()
        {
            Id = 3,
            Title = "History"
        },
        new()
        {
            Id = 4,
            Title = "Science"
        }
    };
}