using KerverosDemo.Data.Common;
using KerverosDemo.Entities;
using System.Linq;

namespace KerverosDemo.Data
{
    public class CustomersRepository : ICustomersRepository
    {
        public Customer[] GetCustomers()
        {
            using(var db = new DatabaseContext())
            {
                return db.Customers.ToArray();
            }
        }

        public Customer GetCustomer(string customerCode)
        {
            using (var db = new DatabaseContext())
            {
                return db.Customers.Find(customerCode);
            }
        }

        public void AddUpdateCustomer(Customer customer)
        {
            using (var db = new DatabaseContext())
            {
                if (db.Customers.Find(customer.CustomerCode) == null)
                {
                    db.Customers.Add(customer);
                }
                else
                {
                    db.Customers.Remove(customer);
                    db.Customers.Add(customer);
                }
            }
        }
        public void DeleteCustomer(Customer customer)
        {
            using (var db = new DatabaseContext())
            {
                db.Customers.Remove(customer);
            }   
        }
    }
}
