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
            totalPaymentAmount += subscription.PriceDetails["FixPrice"];

            UpdateRemainingSubscriptions(subscription, ref remainingSubscriptions, ref oldBookCharge);
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

            totalPaymentAmount += GetNewBookPrice(purchaseTransaction.Book, ref remainingSubscriptions);
        }

        return Math.Round(totalPaymentAmount, 2);
    }

    private static bool CheckSubscription(IReadOnlyDictionary<int, int> remainingSubscriptions, int categoryId)
    {
        if (remainingSubscriptions.TryGetValue(categoryId, out var value))
            return value != 0;

        return false;
    }

    private static double GetNewBookPrice(Book book, ref Dictionary<int, int> remainingSubscriptions)
    {
        var discount = 1.0;
        var categoryIdToCheck = book.CategoryId;

        if (CheckSubscription(remainingSubscriptions, categoryIdToCheck))
        {
            remainingSubscriptions[categoryIdToCheck]--;
            discount = 0.85;
        }
        // Checking for premium subscription
        else if (CheckSubscription(remainingSubscriptions, (int)RemainingSubscriptionType.Premium))
        {
            remainingSubscriptions[(int)RemainingSubscriptionType.Premium]--;
            discount = 0.85;
        }
        // Checking for paid subscription
        else if (CheckSubscription(remainingSubscriptions, (int)RemainingSubscriptionType.Paid))
        {
            remainingSubscriptions[(int)RemainingSubscriptionType.Paid]--;
            discount = 0.95;
        }

        return Math.Round(discount * book.Price, 2);
    }

    private static void UpdateRemainingSubscriptions(Subscription subscription,
        ref Dictionary<int, int> remainingSubscriptions, ref double oldBookCharge)
    {
        var subscriptionId = subscription.Id;
        var subscriptionType = subscription.SubscriptionType;

        switch (subscriptionType)
        {
            case SubscriptionTypes.Free:
            case SubscriptionTypes.Paid:
                oldBookCharge = Math.Min(oldBookCharge, subscription.PriceDetails["OldBookCharge"]);

                // in case of paid account
                if (subscriptionType == SubscriptionTypes.Paid)
                    remainingSubscriptions.Add((int)RemainingSubscriptionType.Paid, 3);
                break;

            // in case of premium account
            case SubscriptionTypes.Premium:
                oldBookCharge = 0;
                remainingSubscriptions.Add((int)RemainingSubscriptionType.Premium, 3);
                break;
            case SubscriptionTypes.CategoryAddicted:
            default:
                var bookCategoryId = subscription.BookCategoryId ?? -1;

                if (bookCategoryId == -1)
                    Console.WriteLine(
                        $"This book category subscription with subscription id {subscriptionId} is not valid.");

                remainingSubscriptions.Add(bookCategoryId, 3);
                break;
        }
    }
}