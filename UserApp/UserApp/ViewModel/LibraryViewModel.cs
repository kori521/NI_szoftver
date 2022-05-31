using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.MobileControls;
using System.Windows.Input;
using UserApp.View;

namespace UserApp.ViewModel
{
    public class LibraryViewModel
    {

        public LibraryViewModel()
        {
            
        }

        private void LoginCommand(LibraryView context)
        {
            LibraryViewModel model = new LibraryViewModel();
            context = new LibraryView(model);
            //this.NavigationService.Navigate(new Uri("Page2.xaml", UriKind.Relative));
            context.NavigationService.Navigate(new Uri("BooksView.xaml", UriKind.Relative));
        }
        public ICommand LoginButtonCommand
        {
            get { return new DelegateCommand<LibraryView>(LoginCommand); }
        }

    }
}
