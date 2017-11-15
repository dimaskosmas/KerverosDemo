using KerverosDemo.Entities;

namespace KerverosDemo.Data.Common
{
    public interface ICustomersRepository
    {
        Customer[] GetCustomers();
        Customer GetCustomer(string customerCode);
        void AddUpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customerCode);
    }
}
