using TrickyBookStore.Services.Customers;
using TrickyBookStore.Services.PurchaseTransactions;

namespace TrickyBookStore.Services.Payment;

internal class PaymentService : IPaymentService
{
    public PaymentService(ICustomerService customerService,
        IPurchaseTransactionService purchaseTransactionService)
    {
        CustomerService = customerService;
        PurchaseTransactionService = purchaseTransactionService;
    }

    private ICustomerService CustomerService { get; }
    private IPurchaseTransactionService PurchaseTransactionService { get; }

    public double GetPaymentAmount(long customerId, int month, int year)
    {
        var totalPaymentAmount = 0.0;
        var oldBookCharge = 1.0;
        var listBookCategory = new List<int>();
        var foundCustomer = CustomerService.GetCustomerById(customerId);

        if (foundCustomer == null)
        {
            Console.WriteLine($"Customer with id {customerId} not found.");
            return 0;
        }

        var foundPurchaseTransactions = PurchaseTransactionService.GetPurchaseTransactions(customerId, month, year);
        var remainingSubscriptions = new Dictionary<int, int>();

        foreach (var subscription in foundCustomer.Subscriptions)
        {
            var subscriptionId = subscription.Id;
            totalPaymentAmount += subscription.PriceDetails["FixPrice"];

            switch (subscriptionId)
            {
                case < 3:
                    oldBookCharge = Math.Min(oldBookCharge, subscription.PriceDetails["OldBookCharge"]);

                    // in case of paid account
                    if (subscriptionId == 1)
                        remainingSubscriptions.Add(-1, 3);

                    continue;

                case 3:
                    oldBookCharge = 0;
                    remainingSubscriptions.Add(0, 3);

                    continue;
            }

            var bookCategoryId = subscription.BookCategoryId ?? -1;

            if (bookCategoryId == -1)
            {
                Console.WriteLine($"This category subscription with id {subscriptionId} is not valid.");

                continue;
            }

            listBookCategory.Add(bookCategoryId);
            remainingSubscriptions.Add(bookCategoryId, 3);
        }

        foreach (var purchaseTransaction in foundPurchaseTransactions)
        {
            var bookCategoryId = purchaseTransaction.Book.CategoryId;
            var isOldBook = purchaseTransaction.Book.IsOld;
            var bookPrice = purchaseTransaction.Book.Price;

            if (isOldBook)
            {
                if (listBookCategory.Contains(bookCategoryId)) continue;

                totalPaymentAmount += oldBookCharge * bookPrice;
                continue;
            }

            // Check and use remaining selected category subscription
            if (remainingSubscriptions.TryGetValue(bookCategoryId, out var categorySubscriptionsLeft) &&
                categorySubscriptionsLeft > 0)
            {
                remainingSubscriptions[bookCategoryId]--;
                totalPaymentAmount += 0.85 * bookPrice;
                continue;
            }

            // Check and use remaining premium subscription
            if (remainingSubscriptions.TryGetValue(0, out var premiumSubscriptionsLeft) &&
                premiumSubscriptionsLeft > 0)
            {
                remainingSubscriptions[0]--;
                totalPaymentAmount += 0.85 * bookPrice;
                continue;
            }

            // Check and use remaining paid subscription
            if (remainingSubscriptions.TryGetValue(-1, out var paidSubscriptionsLeft) && paidSubscriptionsLeft > 0)
            {
                remainingSubscriptions[-1]--;
                totalPaymentAmount += 0.95 * bookPrice;
                continue;
            }

            totalPaymentAmount += bookPrice;
        }

        return totalPaymentAmount;
    }
}