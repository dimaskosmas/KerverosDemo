using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerverosDemo.Entities
{
    public class Customer
    {
        [Key, MaxLength(16)]
        public string CustomerCode { get; set; }
        [MaxLength(60)]
        public string Name { get; set; }
        [MaxLength(60)]
        public string Address { get; set; }

        public Customer(string name, string customerCode, string address)
        {
            Name = name;
            CustomerCode = customerCode;
            Address = address;
        }

        public Customer()
        {

        }
    }
}
