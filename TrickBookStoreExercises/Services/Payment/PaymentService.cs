using TrickBookStoreExercises.Models;
using TrickBookStoreExercises.Services.Customers;
using TrickBookStoreExercises.Services.PurchaseTransactions;

namespace TrickBookStoreExercises.Services.Payment;

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
            var subscriptionType = subscription.SubscriptionType;

            totalPaymentAmount += subscription.PriceDetails["FixPrice"];

            switch (subscriptionType)
            {
                case SubscriptionTypes.Free:
                case SubscriptionTypes.Paid:
                    oldBookCharge = Math.Min(oldBookCharge, subscription.PriceDetails["OldBookCharge"]);

                    // in case of paid account
                    if (subscriptionType == SubscriptionTypes.Paid)
                        remainingSubscriptions.Add(-1, 3);

                    continue;

                // in case of premium account
                case SubscriptionTypes.Premium:
                    oldBookCharge = 0;
                    remainingSubscriptions.Add(0, 3);

                    continue;
            }

            var bookCategoryId = subscription.BookCategoryId ?? -1;

            if (bookCategoryId == -1)
            {
                Console.WriteLine(
                    $"This book category subscription with subscription id {subscriptionId} is not valid.");

                continue;
            }

            remainingSubscriptions.Add(bookCategoryId, 3);
        }

        foreach (var purchaseTransaction in foundPurchaseTransactions)
        {
            var bookCategoryId = purchaseTransaction.Book.CategoryId;
            var isOldBook = purchaseTransaction.Book.IsOld;
            var bookPrice = purchaseTransaction.Book.Price;

            if (isOldBook)
            {
                if (remainingSubscriptions.ContainsKey(bookCategoryId)) continue;

                totalPaymentAmount += oldBookCharge * bookPrice;
                continue;
            }

            // Check and use remaining selected category subscription
            if (CheckSubscription(remainingSubscriptions, bookCategoryId))
            {
                remainingSubscriptions[bookCategoryId]--;
                totalPaymentAmount += 0.85 * bookPrice;
                continue;
            }

            // Check and use remaining premium subscription
            if (CheckSubscription(remainingSubscriptions, 0))
            {
                remainingSubscriptions[0]--;
                totalPaymentAmount += 0.85 * bookPrice;
                continue;
            }

            // Check and use remaining paid subscription
            if (CheckSubscription(remainingSubscriptions, -1))
            {
                remainingSubscriptions[-1]--;
                totalPaymentAmount += 0.95 * bookPrice;
                continue;
            }

            totalPaymentAmount += bookPrice;
        }

        return Math.Round(totalPaymentAmount, 2);
    }

    private static bool CheckSubscription(IReadOnlyDictionary<int, int> remainingSubscriptions, int categoryId)
    {
        if (remainingSubscriptions.TryGetValue(categoryId, out var value))
            return value != 0;

        return false;
    }
}