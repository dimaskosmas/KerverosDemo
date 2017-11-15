
using KerverosDemo.Entities;
using KerverosDemo.UI.Common;

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
