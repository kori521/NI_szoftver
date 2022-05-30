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
using UserApp.Connection;
using UserApp.View;
using UserApp.ViewModel;

namespace UserApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LibraryViewModel model = new LibraryViewModel();
        public MainWindow()
        {
            InitializeComponent();
            Locator.Initialize();
            InitializeServerRepository();
            //FrameContent.Navigate(new LibraryView(model));
        }

        private static async void InitializeServerRepository()
        {
            ServerConnectionRepository connectRepo = Locator.Resolve<ServerConnectionRepository>();
            await connectRepo.StartClient();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //FrameContent.Navigate(new LibraryView());
        }
    }

}
