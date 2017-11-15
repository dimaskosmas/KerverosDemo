using KerverosDemo.Entities;

namespace KerverosDemo.Data.Common
{
    public interface ICustomersRepository
    {
        Customer[] GetCustomers();
        Customer GetCustomer(string customerCode);
        Customer AddCustomer(Customer customer);
        Customer SaveCustomer(Customer customer);
        Customer DeleteCustomer(Customer customerCode);
    }
}
