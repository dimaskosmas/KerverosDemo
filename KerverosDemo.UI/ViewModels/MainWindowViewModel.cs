using KerverosDemo.Entities;
using KerverosDemo.Services;
using KerverosDemo.UI.Common;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;

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
            foreach (Customer cust in new CustomerService().GetCustomers().ToList())
            {
                Customers.Add(cust);
            }
        }
    }
}
