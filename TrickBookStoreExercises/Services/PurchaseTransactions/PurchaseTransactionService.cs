using TrickBookStoreExercises.Models;
using TrickBookStoreExercises.Services.Books;

namespace TrickBookStoreExercises.Services.PurchaseTransactions;

internal class PurchaseTransactionService : IPurchaseTransactionService
{
    public PurchaseTransactionService(IBookService bookService)
    {
        BookService = bookService;
    }

    private IBookService BookService { get; }

    public IEnumerable<PurchaseTransaction> GetPurchaseTransactions(long customerId, int month, int year)
    {
        var foundPurchaseTransactions = new List<PurchaseTransaction>();

        foreach (var purchaseTransaction in Store.PurchaseTransactions.Data)
            if (purchaseTransaction.CustomerId == customerId &&
                purchaseTransaction.CreatedDate.Year == year &&
                purchaseTransaction.CreatedDate.Month == month)
            {
                var foundBook = BookService.GetBookById(purchaseTransaction.BookId);

                if (foundBook == null)
                {
                    Console.WriteLine($"Book with id {purchaseTransaction.BookId} not found.");
                    continue;
                }

                purchaseTransaction.Book = foundBook;
                foundPurchaseTransactions.Add(purchaseTransaction);
            }

        return foundPurchaseTransactions;
    }
}