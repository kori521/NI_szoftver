using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System;
using UserApp.ViewModel;

namespace UserApp.View
{
    /// <summary>
    /// Interaction logic for LibraryView.xaml
    /// </summary>
    public partial class LibraryView : Page
    {
        private LibraryViewModel model;
        public LibraryView(LibraryViewModel model)
        {
            InitializeComponent();
            this.model = model;
            
        }
    }
}
