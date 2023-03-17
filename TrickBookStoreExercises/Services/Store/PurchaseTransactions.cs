﻿using TrickyBookStore.Models;

namespace TrickyBookStore.Services.Store;

public static class PurchaseTransactions
{
    public static readonly IEnumerable<PurchaseTransaction> Data = new List<PurchaseTransaction>
    {
        new() { Id = 1, CustomerId = 1, BookId = 1, CreatedDate = new DateTimeOffset(new DateTime(2018, 1, 2)) },
        new() { Id = 2, CustomerId = 1, BookId = 2, CreatedDate = new DateTimeOffset(new DateTime(2018, 1, 10)) },
        new() { Id = 3, CustomerId = 1, BookId = 3, CreatedDate = new DateTimeOffset(new DateTime(2018, 1, 20)) },
        new() { Id = 4, CustomerId = 1, BookId = 4, CreatedDate = new DateTimeOffset(new DateTime(2018, 1, 21)) },
        new() { Id = 5, CustomerId = 2, BookId = 1, CreatedDate = new DateTimeOffset(new DateTime(2018, 1, 2)) },
        new() { Id = 6, CustomerId = 2, BookId = 2, CreatedDate = new DateTimeOffset(new DateTime(2018, 1, 10)) },
        new() { Id = 7, CustomerId = 2, BookId = 3, CreatedDate = new DateTimeOffset(new DateTime(2018, 1, 20)) },
        new() { Id = 8, CustomerId = 2, BookId = 4, CreatedDate = new DateTimeOffset(new DateTime(2018, 1, 21)) },
        new() { Id = 9, CustomerId = 3, BookId = 1, CreatedDate = new DateTimeOffset(new DateTime(2018, 1, 2)) },
        new() { Id = 10, CustomerId = 3, BookId = 2, CreatedDate = new DateTimeOffset(new DateTime(2018, 1, 10)) },
        new() { Id = 11, CustomerId = 3, BookId = 3, CreatedDate = new DateTimeOffset(new DateTime(2018, 1, 20)) },
        new() { Id = 12, CustomerId = 3, BookId = 4, CreatedDate = new DateTimeOffset(new DateTime(2018, 1, 21)) },
        new() { Id = 13, CustomerId = 4, BookId = 5, CreatedDate = new DateTimeOffset(new DateTime(2018, 1, 2)) },
        new() { Id = 14, CustomerId = 4, BookId = 2, CreatedDate = new DateTimeOffset(new DateTime(2018, 1, 10)) },
        new() { Id = 15, CustomerId = 4, BookId = 3, CreatedDate = new DateTimeOffset(new DateTime(2018, 1, 20)) },
        new() { Id = 16, CustomerId = 4, BookId = 4, CreatedDate = new DateTimeOffset(new DateTime(2018, 1, 21)) },
        new() { Id = 17, CustomerId = 5, BookId = 1, CreatedDate = new DateTimeOffset(new DateTime(2018, 1, 2)) },
        new() { Id = 18, CustomerId = 5, BookId = 2, CreatedDate = new DateTimeOffset(new DateTime(2018, 1, 10)) },
        new() { Id = 19, CustomerId = 5, BookId = 3, CreatedDate = new DateTimeOffset(new DateTime(2018, 1, 20)) },
        new() { Id = 20, CustomerId = 5, BookId = 4, CreatedDate = new DateTimeOffset(new DateTime(2018, 1, 21)) },
        new() { Id = 21, CustomerId = 1, BookId = 6, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 25)) },
        new() { Id = 22, CustomerId = 1, BookId = 7, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 10)) },
        new() { Id = 23, CustomerId = 1, BookId = 8, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 20)) },
        new() { Id = 24, CustomerId = 1, BookId = 9, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 21)) },
        new() { Id = 25, CustomerId = 2, BookId = 6, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 24)) },
        new() { Id = 26, CustomerId = 2, BookId = 7, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 10)) },
        new() { Id = 27, CustomerId = 2, BookId = 8, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 20)) },
        new() { Id = 28, CustomerId = 2, BookId = 9, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 21)) },
        new() { Id = 29, CustomerId = 3, BookId = 6, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 26)) },
        new() { Id = 30, CustomerId = 3, BookId = 7, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 10)) },
        new() { Id = 31, CustomerId = 3, BookId = 8, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 20)) },
        new() { Id = 32, CustomerId = 3, BookId = 9, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 21)) },
        new() { Id = 33, CustomerId = 7, BookId = 10, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 25)) },
        new() { Id = 34, CustomerId = 7, BookId = 7, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 10)) },
        new() { Id = 35, CustomerId = 7, BookId = 8, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 20)) },
        new() { Id = 36, CustomerId = 7, BookId = 9, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 21)) },
        new() { Id = 37, CustomerId = 7, BookId = 11, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 1)) },
        new() { Id = 38, CustomerId = 7, BookId = 12, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 2)) },
        new() { Id = 39, CustomerId = 7, BookId = 13, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 5)) },
        new() { Id = 40, CustomerId = 5, BookId = 6, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 24)) },
        new() { Id = 41, CustomerId = 5, BookId = 7, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 10)) },
        new() { Id = 42, CustomerId = 5, BookId = 8, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 20)) },
        new() { Id = 43, CustomerId = 5, BookId = 9, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 21)) },
        new() { Id = 44, CustomerId = 5, BookId = 10, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 1)) },
        new() { Id = 45, CustomerId = 5, BookId = 12, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 2)) },
        new() { Id = 46, CustomerId = 5, BookId = 11, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 5)) },
        new() { Id = 47, CustomerId = 5, BookId = 13, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 25)) },
        new() { Id = 48, CustomerId = 5, BookId = 14, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 26)) },
        new() { Id = 49, CustomerId = 5, BookId = 15, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 27)) },
        new() { Id = 50, CustomerId = 5, BookId = 16, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 28)) },
        new() { Id = 51, CustomerId = 6, BookId = 6, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 24)) },
        new() { Id = 52, CustomerId = 6, BookId = 7, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 10)) },
        new() { Id = 53, CustomerId = 6, BookId = 8, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 20)) },
        new() { Id = 54, CustomerId = 6, BookId = 9, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 21)) },
        new() { Id = 55, CustomerId = 6, BookId = 10, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 1)) },
        new() { Id = 56, CustomerId = 6, BookId = 12, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 2)) },
        new() { Id = 57, CustomerId = 6, BookId = 11, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 5)) },
        new() { Id = 58, CustomerId = 6, BookId = 13, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 25)) },
        new() { Id = 59, CustomerId = 6, BookId = 14, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 26)) },
        new() { Id = 60, CustomerId = 6, BookId = 15, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 27)) },
        new() { Id = 61, CustomerId = 6, BookId = 16, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 28)) },
        new() { Id = 62, CustomerId = 6, BookId = 17, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 12)) },
        new() { Id = 63, CustomerId = 6, BookId = 18, CreatedDate = new DateTimeOffset(new DateTime(2018, 2, 14)) },

        new() { Id = 64, CustomerId = 5, BookId = 1, CreatedDate = new DateTimeOffset(new DateTime(2018, 3, 2)) },
        new() { Id = 65, CustomerId = 5, BookId = 2, CreatedDate = new DateTimeOffset(new DateTime(2018, 3, 10)) },
        new() { Id = 66, CustomerId = 5, BookId = 3, CreatedDate = new DateTimeOffset(new DateTime(2018, 3, 20)) },
        new() { Id = 67, CustomerId = 5, BookId = 4, CreatedDate = new DateTimeOffset(new DateTime(2018, 3, 21)) },
        new() { Id = 68, CustomerId = 5, BookId = 6, CreatedDate = new DateTimeOffset(new DateTime(2018, 3, 24)) },
        new() { Id = 69, CustomerId = 5, BookId = 7, CreatedDate = new DateTimeOffset(new DateTime(2018, 3, 10)) },
        new() { Id = 70, CustomerId = 5, BookId = 8, CreatedDate = new DateTimeOffset(new DateTime(2018, 3, 20)) },
        new() { Id = 71, CustomerId = 5, BookId = 9, CreatedDate = new DateTimeOffset(new DateTime(2018, 3, 21)) },
        new() { Id = 72, CustomerId = 5, BookId = 10, CreatedDate = new DateTimeOffset(new DateTime(2018, 3, 1)) },
        new() { Id = 73, CustomerId = 5, BookId = 12, CreatedDate = new DateTimeOffset(new DateTime(2018, 3, 2)) },
        new() { Id = 74, CustomerId = 5, BookId = 11, CreatedDate = new DateTimeOffset(new DateTime(2018, 3, 5)) },
        new() { Id = 75, CustomerId = 5, BookId = 13, CreatedDate = new DateTimeOffset(new DateTime(2018, 3, 25)) },
        new() { Id = 76, CustomerId = 5, BookId = 14, CreatedDate = new DateTimeOffset(new DateTime(2018, 3, 26)) },
        new() { Id = 77, CustomerId = 5, BookId = 15, CreatedDate = new DateTimeOffset(new DateTime(2018, 3, 27)) },
        new() { Id = 78, CustomerId = 5, BookId = 16, CreatedDate = new DateTimeOffset(new DateTime(2018, 3, 28)) }
    };
}