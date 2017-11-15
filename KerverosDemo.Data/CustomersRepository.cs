using KerverosDemo.Data.Common;
using KerverosDemo.Entities;
using System;
using System.Diagnostics;
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

        public Customer AddCustomer(Customer customer)
        {
            using (var db = new DatabaseContext())
            {
                var existing = db.Customers.FirstOrDefault(s=> s.CustomerCode.Equals(customer.CustomerCode));
                if (existing == null)
                {
                    try
                    {
                        var c = db.Customers.Add(customer);
                        db.SaveChanges();
                        return c;
                    }
                    catch (Exception e)
                    {

                        Debug.WriteLine(e);
                    }
                }
                throw new NullReferenceException("Customer already exists");
            }
        }

        public Customer SaveCustomer(Customer customer)
        {
            using (var db = new DatabaseContext())
            {
                var existing = db.Customers.FirstOrDefault(s => s.CustomerCode.Equals(customer.CustomerCode));
                if (existing != null)
                {
                    existing.CustomerCode = customer.CustomerCode;
                    existing.Address = customer.Address;
                    existing.Name = customer.Name;
                    db.Entry(existing).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return customer;
                }
                return AddCustomer(customer);
            }
        }
        public Customer DeleteCustomer(Customer customer)
        {
            using (var db = new DatabaseContext())
            {
                var existing = db.Customers.FirstOrDefault(s => s.CustomerCode.Equals(customer.CustomerCode));
                if (existing != null)
                {
                    db.Customers.Remove(existing);
                    db.SaveChanges();
                }

                return null;
            }   
        }
    }
}
