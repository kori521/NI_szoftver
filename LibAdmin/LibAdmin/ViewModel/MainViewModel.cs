using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibAdmin.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            InitCommand();
        }

        private void InitCommand()
        {
            testcommand = new AsyncCommand(testbuttonclick);
        }
        private async Task testbuttonclick()
        {
            Console.WriteLine("mükszik");
        }
        public ICommand testcommand { get; set; }
    }
}
