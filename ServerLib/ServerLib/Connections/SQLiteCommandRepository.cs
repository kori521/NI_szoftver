using ServerLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLib.Connections
{
    public interface SQLiteCommandRepository
    {
        public Task Initialize(); //Initialize the database
        public Task<List<Library>> GetBooks();
        public Task<List<Users>> GetUsers();
        public Task<List<Booking>> GetBooking();
    }
}
