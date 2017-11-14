using KerverosDemo.UI.ViewModels;
using System.Windows;


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
            var vm = new MainWindowViewModel();
            vm.Initialize();
            DataContext = vm;
        }

    }
}
