using TrickBookStoreExercises.Models;

// KeepIt
namespace TrickBookStoreExercises.Services.Customers;

public interface ICustomerService
{
    Customer? GetCustomerById(long id);
}