using TrickBookStoreExercises.Models;

namespace TrickBookStoreExercises.Services.Subscriptions;

internal class SubscriptionService : ISubscriptionService
{
    public IList<Subscription> GetSubscriptions(params int[] ids)
    {
        var foundSubscriptions = new List<Subscription>();

        foreach (var id in ids)
        {
            var searchedSubscription =
                Store.Subscriptions.Data.FirstOrDefault(data => data.Id == id);

            if (searchedSubscription == null)
            {
                Console.WriteLine($"Subscription with id {id} not found.");
                continue;
            }

            foundSubscriptions.Add(searchedSubscription);
        }

        return foundSubscriptions;
    }
}