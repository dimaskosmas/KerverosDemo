﻿
using System.Collections;
using System.Collections.Generic;

namespace KerverosDemo.Entities
{
    public class Customer : EntityBase
    {
        private string customerCode;
        private string name;
        private string address;

        public string CustomerCode
        {
            get
            {
                return customerCode;
            }
            set
            {
                customerCode = value;
                SetProperty();
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                SetProperty();
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
                SetProperty();
            }
        }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Zone> Zones { get; set; }
        public virtual ICollection<Partition> Partitions { get; set; }

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
