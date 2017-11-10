using KerverosDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerverosDemo.Data.Common
{
    public interface ICustomersRepository
    {
        Customer[] GetCustomers();
    }
}
