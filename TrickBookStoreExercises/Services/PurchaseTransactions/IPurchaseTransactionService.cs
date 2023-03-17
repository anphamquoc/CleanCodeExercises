using TrickBookStoreExercises.Models;

namespace TrickBookStoreExercises.Services.PurchaseTransactions;

// KeepIt
public interface IPurchaseTransactionService
{
    IEnumerable<PurchaseTransaction> GetPurchaseTransactions(long customerId, int month, int year);
}