using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LibAdmin.ViewModel
{
    public class ViewModelBase : BindableObject
    {
        public INavigation Navigation { get; set; }

        internal void OnDisappearing()
        {
            throw new NotImplementedException();
        }
    }
}
