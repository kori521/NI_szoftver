using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLib.Connections
{
    public interface ServerConnectionRepository
    {
        public Task StartServer(); //Starting server
    }
}
