using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp.Connection
{
    public interface ServerConnectionRepository
    {
        public Task StartClient();
    }
}
