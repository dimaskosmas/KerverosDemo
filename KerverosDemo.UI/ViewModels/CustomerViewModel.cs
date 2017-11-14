
using KerverosDemo.Entities;
using KerverosDemo.UI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerverosDemo.UI.Model
{
    public class CustomerViewModel : ViewModelBase
    {
        public CustomerViewModel(Customer customer)
        {
            Customer = customer;
        }

        public Customer Customer { get; set; }
    }
}
