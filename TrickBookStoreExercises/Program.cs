using Microsoft.Extensions.DependencyInjection;
using TrickyBookStore.Services.Books;
using TrickyBookStore.Services.Customers;
using TrickyBookStore.Services.Payment;
using TrickyBookStore.Services.PurchaseTransactions;
using TrickyBookStore.Services.Subscriptions;

var services = new ServiceCollection();

services.AddScoped<ICustomerService, CustomerService>();
services.AddScoped<IBookService, BookService>();
services.AddScoped<IPaymentService, PaymentService>();
services.AddScoped<IPurchaseTransactionService, PurchaseTransactionService>();
services.AddScoped<ISubscriptionService, SubscriptionService>();

var serviceProvider = services.BuildServiceProvider();

var paymentService = serviceProvider.GetService<IPaymentService>();

var paymentAmount = paymentService.GetPaymentAmount(6, 2, 2018);

Console.WriteLine(paymentAmount);