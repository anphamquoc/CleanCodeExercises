using TrickyBookStore.Models;

namespace TrickyBookStore.Services.Store;

public static class Books
{
    public static readonly IEnumerable<Book> Data = new List<Book>
    {
        new() { Id = 1, CategoryId = 1, IsOld = true, Price = 34 },
        new() { Id = 2, CategoryId = 2, IsOld = true, Price = 25 },
        new() { Id = 3, CategoryId = 3, IsOld = true, Price = 20 },
        new() { Id = 4, CategoryId = 4, IsOld = true, Price = 16 },
        new() { Id = 5, CategoryId = 3, IsOld = true, Price = 9.99 },
        new() { Id = 6, CategoryId = 1, IsOld = false, Price = 70 },
        new() { Id = 7, CategoryId = 2, IsOld = false, Price = 69 },
        new() { Id = 8, CategoryId = 3, IsOld = false, Price = 55 },
        new() { Id = 9, CategoryId = 4, IsOld = false, Price = 88 },
        new() { Id = 10, CategoryId = 2, IsOld = false, Price = 76 },
        new() { Id = 11, CategoryId = 2, IsOld = false, Price = 85 },
        new() { Id = 12, CategoryId = 1, IsOld = false, Price = 74 },
        new() { Id = 13, CategoryId = 2, IsOld = false, Price = 65 },
        new() { Id = 14, CategoryId = 3, IsOld = false, Price = 45 },
        new() { Id = 15, CategoryId = 1, IsOld = false, Price = 33 },
        new() { Id = 16, CategoryId = 1, IsOld = false, Price = 81 },
        new() { Id = 17, CategoryId = 4, IsOld = false, Price = 42 },
        new() { Id = 18, CategoryId = 2, IsOld = false, Price = 82 }
    };
}