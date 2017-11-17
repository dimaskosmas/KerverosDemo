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

                //var existing = db.Customers.FirstOrDefault(s => s.CustomerCode.Equals(customer.CustomerCode));
                
                if (db.Customers.FirstOrDefault(s => s.CustomerCode.Equals(customer.CustomerCode)) == null && customer.CustomerCode != null && customer.CustomerCode != string.Empty)
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
                return customer;           
            }
        }

        public Customer SaveCustomer(Customer customer)
        {
            using (var db = new DatabaseContext())
            {
                try
                {
                    var existing = db.Customers.FirstOrDefault(s => s.CustomerCode.Equals(customer.CustomerCode));
                    if (existing != null && customer.CustomerCode != null && customer.CustomerCode != "")
                    {
                        existing.CustomerCode = customer.CustomerCode;
                        existing.Address = customer.Address;
                        existing.Name = customer.Name;
                        db.Entry(existing).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        return customer;
                    }
                }
                catch (Exception e)
                {

                    Debug.WriteLine(e);
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
