using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Practice31._05
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            processesDataGrid.ItemsSource = Process.GetProcesses();
        }

        private void RemoveTaskButtonClick(object sender, RoutedEventArgs e)
        {
            foreach (var process in Process.GetProcesses())
            {
                if ((processesDataGrid.SelectedItem as Process).Id == process.Id)
                {
                    try
                    {
                        process.Kill();
                    }
                    catch
                    {
                        MessageBox.Show("Недоступно");
                    }
                    break;
                }
            }
            processesDataGrid.ItemsSource = Process.GetProcesses();
        }

    }
}