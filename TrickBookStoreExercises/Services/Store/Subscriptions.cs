using TrickBookStoreExercises.Models;

namespace TrickBookStoreExercises.Services.Store;

public static class Subscriptions
{
    public static readonly IEnumerable<Subscription> Data = new List<Subscription>
    {
        new()
        {
            Id = 1, SubscriptionType = SubscriptionTypes.Paid, Priority = 1,
            PriceDetails = new Dictionary<string, double>
            {
                {
                    "FixPrice", (double)FixedPrice.Paid
                },
                {
                    "OldBookCharge", 0.05
                }
            }
        },
        new()
        {
            Id = 2, SubscriptionType = SubscriptionTypes.Free, Priority = 0,
            PriceDetails = new Dictionary<string, double>
            {
                {
                    "FixPrice", (double)FixedPrice.Free
                },
                {
                    "OldBookCharge", 0.9
                }
            }
        },
        new()
        {
            Id = 3, SubscriptionType = SubscriptionTypes.Premium, Priority = 2,
            PriceDetails = new Dictionary<string, double>
            {
                { "FixPrice", (double)FixedPrice.Premium },
                {
                    "OldBookCharge", 0
                }
            }
        },
        new()
        {
            Id = 4, SubscriptionType = SubscriptionTypes.CategoryAddicted, Priority = 3,
            PriceDetails = new Dictionary<string, double>
            {
                {
                    "FixPrice", (double)FixedPrice.CategoryAddictive
                },
                {
                    "OldBookCharge", 1
                }
            },
            BookCategoryId = 1
        },
        new()
        {
            Id = 5, SubscriptionType = SubscriptionTypes.CategoryAddicted, Priority = 3,
            PriceDetails = new Dictionary<string, double>
            {
                { "FixPrice", (double)FixedPrice.CategoryAddictive },
                {
                    "OldBookCharge", 1
                }
            },
            BookCategoryId = 2
        },
        new()
        {
            Id = 6, SubscriptionType = SubscriptionTypes.CategoryAddicted, Priority = 3,
            PriceDetails = new Dictionary<string, double>
            {
                { "FixPrice", (double)FixedPrice.CategoryAddictive },
                {
                    "OldBookCharge", 1
                }
            },
            BookCategoryId = 3
        },
        new()
        {
            Id = 7, SubscriptionType = SubscriptionTypes.CategoryAddicted, Priority = 3,
            PriceDetails = new Dictionary<string, double>
            {
                { "FixPrice", (double)FixedPrice.CategoryAddictive },
                {
                    "OldBookCharge", 1
                }
            },
            BookCategoryId = 4
        }
    };

    private enum FixedPrice
    {
        CategoryAddictive = 75,
        Premium = 200,
        Paid = 50,
        Free = 0
    }
}