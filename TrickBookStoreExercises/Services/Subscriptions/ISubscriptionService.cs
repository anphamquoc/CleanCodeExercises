using TrickBookStoreExercises.Models;

namespace TrickBookStoreExercises.Services.Subscriptions;

public interface ISubscriptionService
{
    IList<Subscription> GetSubscriptions(params int[] ids);
}