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
    }

    private void StudentViewControl_Loaded(object sender, RoutedEventArgs e)
    {
        ViewModel.StudentViewModel studentViewModelObject = new ViewModel.StudentViewModel();

        studentViewModelObject.LoadStudents();

        StudentViewControl.DataContext = studentViewModelObject;
    }
}
}
