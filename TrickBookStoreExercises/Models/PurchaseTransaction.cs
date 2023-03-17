// KeepIt

namespace TrickBookStoreExercises.Models;

public class PurchaseTransaction
{
    public long Id { get; set; }
    public long CustomerId { get; set; }
    public long BookId { get; set; }
    public DateTimeOffset CreatedDate { get; set; }

    public Book Book { get; set; }
}