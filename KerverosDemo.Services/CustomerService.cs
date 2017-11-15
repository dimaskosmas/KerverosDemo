using KerverosDemo.Data;
using KerverosDemo.Entities;

namespace KerverosDemo.Services
{
    public class CustomerService : ServiceBase<IService>
    {
        public CustomerService()
        {
        }

        public Customer[] GetCustomers()
        {
            var db = new CustomersRepository();
            return db.GetCustomers();
        }

        public Customer SaveCustomer(Customer customer)
        {
            var db = new CustomersRepository();
            return db.SaveCustomer(customer);
        }

        public Customer DeleteCustomer(Customer customer)
        {
            var db = new CustomersRepository();
            return db.DeleteCustomer(customer);
        }
    }
}
