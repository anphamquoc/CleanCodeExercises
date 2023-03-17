using Microsoft.Extensions.DependencyInjection;
using TrickBookStoreExercises.Services.Books;
using TrickBookStoreExercises.Services.Customers;
using TrickBookStoreExercises.Services.Payment;
using TrickBookStoreExercises.Services.PurchaseTransactions;
using TrickBookStoreExercises.Services.Subscriptions;
using TrickyBookStore.Services.Customers;

var services = new ServiceCollection();

services.AddScoped<ICustomerService, CustomerService>();
services.AddScoped<IBookService, BookService>();
services.AddScoped<IPaymentService, PaymentService>();
services.AddScoped<IPurchaseTransactionService, PurchaseTransactionService>();
services.AddScoped<ISubscriptionService, SubscriptionService>();

var serviceProvider = services.BuildServiceProvider();

var paymentService = serviceProvider.GetService<IPaymentService>();

if (paymentService != null)
{
    var paymentAmount = paymentService.GetPaymentAmount(1, 1, 2018);

    Console.WriteLine(paymentAmount);
}