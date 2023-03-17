using TrickyBookStore.Models;

namespace TrickyBookStore.Services.Store;

public static class Customers
{
    public static readonly IEnumerable<Customer> Data = new List<Customer>
    {
        new() { Id = 1, Name = "Pham Quoc An", SubscriptionIds = new List<int> { 1 } },
        new() { Id = 2, Name = "Maariyah Morrison", SubscriptionIds = new List<int> { 1 } },
        new() { Id = 3, Name = "Leroy Meyer", SubscriptionIds = new List<int> { 3 } },
        new() { Id = 4, Name = "Liliana Roy", SubscriptionIds = new List<int> { 6 } },
        new() { Id = 5, Name = "Melody Beltran", SubscriptionIds = new List<int> { 1, 5, 4 } },
        new() { Id = 6, Name = "Jasmin Baird", SubscriptionIds = new List<int> { 1, 3, 5, 4 } },
        new() { Id = 7, Name = "Macie French", SubscriptionIds = new List<int> { 4 } }
    };
}