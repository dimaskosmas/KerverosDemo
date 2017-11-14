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
    }
}
