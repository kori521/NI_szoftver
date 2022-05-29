using ServerLib.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLib.Connections
{
    public class SQLiteConnection : SQLiteCommandRepository
    {
        private SQLiteAsyncConnection _connection;
        private static string dbName = Path.Combine(Environment.CurrentDirectory, "Library.db");
        public async Task Initialize()
        {
            if (_connection != null) return;
            _connection = new SQLiteAsyncConnection(dbName, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.FullMutex, false);
            try
            {
                //itt kell hozzaadni az uj adatbazis objektumokat
                await _connection.CreateTableAsync<Library>();
                await _connection.CreateTableAsync<Booking>();
                await _connection.CreateTableAsync<Users>();
                //var obj = new Library
                //{
                //    id = 0,
                //    cim = "test1",
                //    szoveg = "smol",
                //};
                //for (int i = 3; i < 6; i++)
                //{
                //    obj.id = i;
                //    await _connection.InsertAsync(obj);
                //}
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public Task<List<Library>> GetBooks() =>
            _connection.Table<Library>().ToListAsync();

        public Task<List<Users>> GetUsers() =>
           _connection.Table<Users>().ToListAsync();

        public Task<List<Booking>> GetBooking() =>
           _connection.Table<Booking>().OrderBy(x => x.return_date).ToListAsync();

    }
}
