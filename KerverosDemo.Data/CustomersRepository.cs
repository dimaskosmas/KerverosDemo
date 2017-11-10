using KerverosDemo.Data.Common;
using KerverosDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
