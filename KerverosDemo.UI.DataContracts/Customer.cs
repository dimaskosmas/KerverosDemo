using KerverosDemo.UI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerverosDemo.UI.DataContracts
{
    public class Customer : ObjectBase
    {
        private string customerCode;
        private string name;
        private string address;

        public string CustomerCode {
            get
            {
                return customerCode;
            }
            set
            {
                if (customerCode.Equals(value)) return;
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
                if (name.Equals(value)) return;
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
                if (address.Equals(value)) return;
                address = value;
                SetProperty();
            }
        }
    }
}
