using TrickyBookStore.Models;
using TrickyBookStore.Services.Subscriptions;

namespace TrickyBookStore.Services.Customers;

internal class CustomerService : ICustomerService
{
    public CustomerService(ISubscriptionService subscriptionService)
    {
        SubscriptionService = subscriptionService;
    }

    private ISubscriptionService SubscriptionService { get; }


    public Customer? GetCustomerById(long id)
    {
        var searchedCustomer = Store.Customers.Data.FirstOrDefault(data => data.Id == id);

        if (searchedCustomer == null)
        {
            Console.WriteLine($"Customer with id {id} not found.");
            return null;
        }

        searchedCustomer.Subscriptions =
            SubscriptionService.GetSubscriptions(searchedCustomer.SubscriptionIds.ToArray());

        return searchedCustomer;
    }
}