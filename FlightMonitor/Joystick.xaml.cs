﻿using System;
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

namespace FlightMonitor
{
    /// <summary>
    /// Interaction logic for Joystick.xaml
    /// </summary>
    public partial class Joystick : UserControl
    {
        private FlightgearMonitorViewModel VM;
        public Joystick()
        {
            InitializeComponent();
        }
        public void HookVM(IFlightgearMonitorModel model)
        {
            VM = new FlightgearMonitorViewModel(model);
            DataContext = VM;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
        }

        private void Rudder_slider(object sender, RoutedEventArgs e)
        {
            
        }
    }
}