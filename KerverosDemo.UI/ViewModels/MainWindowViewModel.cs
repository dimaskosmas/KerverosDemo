using KerverosDemo.Entities;
using KerverosDemo.Services;
using KerverosDemo.UI.Common;
using Prism.Commands;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Input;

namespace KerverosDemo.UI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            Customers = new ObservableCollection<Customer>();
            AddCustomerCommand = new DelegateCommand(OnAddCustomer);
            SaveCustomerCommand = new DelegateCommand(OnSaveCustomer);
            DeleteCustomerCommand = new DelegateCommand(OnDeleteCustomer);
        }
                

        public ObservableCollection<Customer> Customers { get; set; }
        private Customer selectedCustomer;
        public DelegateCommand AddCustomerCommand { get; set; }
        public DelegateCommand SaveCustomerCommand { get; set; }
        public DelegateCommand DeleteCustomerCommand { get; set; }
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

        private void OnAddCustomer()
        {
            SelectedCustomer = new Customer();
        }

        private void OnSaveCustomer()
        {
            var service = new CustomerService();
            var c = service.SaveCustomer(SelectedCustomer);
            if(c!= null && c.CustomerCode != null && c.CustomerCode != string.Empty)
            {
                try
                {
                    var existing = Customers.FirstOrDefault(s => s.CustomerCode.Equals(c.CustomerCode));
                    if (existing == null && (c.CustomerCode != string.Empty || c.CustomerCode != null))
                    {
                        Customers.Add(c);
                        return;
                    }
                    existing.CustomerCode = c.CustomerCode;
                    existing.Address = c.Address;
                    existing.Name = c.Name;
                }
                catch (System.Exception e)
                {
                    Debug.WriteLine(e);
                }
                return;
                
            }
        }

        private void OnDeleteCustomer()
        {
            try
            {
                var service = new CustomerService();
                service.DeleteCustomer(SelectedCustomer);
                var existing = Customers.FirstOrDefault(s => s.CustomerCode.Equals(SelectedCustomer.CustomerCode));
                Customers.Remove(SelectedCustomer);
                
            }
            catch (System.Exception e)
            {
                Debug.WriteLine(e);
                
            }
        }
    }
}
