using KerverosDemo.Entities;
using KerverosDemo.Services;
using KerverosDemo.UI.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerverosDemo.UI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            Customers = new ObservableCollection<Customer>();
        }

        public ObservableCollection<Customer> Customers { get; set; }
        private Customer selectedCustomer;

        public Customer SelectedCustomer
        {
            get
            {
                return selectedCustomer;
            }
            set
            {
                if (value == selectedCustomer) return;
                selectedCustomer = value;
                SetProperty();
            }
        }

        public void Initialize()
        {
            var service = new CustomerService();
            var c = service.GetCustomers();
            foreach(Customer cust in c)
            {
                Customers.Add(cust);
            }
        }
    }
}
