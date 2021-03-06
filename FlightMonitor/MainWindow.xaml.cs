using System.Diagnostics;
using System.Windows;
using Microsoft.Win32;
namespace FlightMonitor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IFlightgearMonitorModel model;
        MainWindowViewModel vm;
        public MainWindow()
        {
            InitializeComponent();
            model = new MyFlightgearMonitorModel(new MyTelnetClient());
            vm = new MainWindowViewModel(model);
            ControlBar1.HookVM(model);
            GraphsView1.HookVM(model);
            FlightDetails1.HookVM(model);
            Joystick1.HookVM(model);
            DataContext = vm;
            main_window.Show();
        }

        private void Fly_default_click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV file (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == true)
            {
                Debug.WriteLine(openFileDialog.FileName);
                vm.VM_Path = openFileDialog.FileName;
            }

        }

        private void Load_xml(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML file (*.xml)|*.xml";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.InitialDirectory = @"C:\Program Files\FlightGear 2020.3.6\data\Protocol\";
            if (openFileDialog.ShowDialog() == true)
            {
                Debug.WriteLine(openFileDialog.FileName);
                vm.VM_XML = openFileDialog.FileName;
            }
        }

        

        private void listBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}