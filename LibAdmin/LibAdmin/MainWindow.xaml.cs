using LibAdmin.View;
using LibAdmin.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace LibAdmin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal MainViewModel model;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void asd_Click(object sender, RoutedEventArgs e)
        {
            Menu.Content = new MainView(model);
        }
    }
}
