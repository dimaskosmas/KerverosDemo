using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KerverosDemo.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            KerverosDemo.UI.KerverosDemoDataSet kerverosDemoDataSet = ((KerverosDemo.UI.KerverosDemoDataSet)(this.FindResource("kerverosDemoDataSet")));
            // Load data into the table Customers. You can modify this code as needed.
            KerverosDemo.UI.KerverosDemoDataSetTableAdapters.CustomersTableAdapter kerverosDemoDataSetCustomersTableAdapter = new KerverosDemo.UI.KerverosDemoDataSetTableAdapters.CustomersTableAdapter();
            kerverosDemoDataSetCustomersTableAdapter.Fill(kerverosDemoDataSet.Customers);
            System.Windows.Data.CollectionViewSource customersViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("customersViewSource")));
            customersViewSource.View.MoveCurrentToFirst();
            KerverosDemo.UI.KerverosDemoDataSet kerverosDemoDataSet = ((KerverosDemo.UI.KerverosDemoDataSet)(this.FindResource("kerverosDemoDataSet")));
            // Load data into the table Customers. You can modify this code as needed.
            KerverosDemo.UI.KerverosDemoDataSetTableAdapters.CustomersTableAdapter kerverosDemoDataSetCustomersTableAdapter = new KerverosDemo.UI.KerverosDemoDataSetTableAdapters.CustomersTableAdapter();
            kerverosDemoDataSetCustomersTableAdapter.Fill(kerverosDemoDataSet.Customers);
            System.Windows.Data.CollectionViewSource customersViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("customersViewSource")));
            customersViewSource.View.MoveCurrentToFirst();
            KerverosDemo.UI.KerverosDemoDataSet kerverosDemoDataSet = ((KerverosDemo.UI.KerverosDemoDataSet)(this.FindResource("kerverosDemoDataSet")));
            // Load data into the table Customers. You can modify this code as needed.
            KerverosDemo.UI.KerverosDemoDataSetTableAdapters.CustomersTableAdapter kerverosDemoDataSetCustomersTableAdapter = new KerverosDemo.UI.KerverosDemoDataSetTableAdapters.CustomersTableAdapter();
            kerverosDemoDataSetCustomersTableAdapter.Fill(kerverosDemoDataSet.Customers);
            System.Windows.Data.CollectionViewSource customersViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("customersViewSource")));
            customersViewSource.View.MoveCurrentToFirst();
        }
    }
}
