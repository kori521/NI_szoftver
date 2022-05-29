using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using ServerLib.Connections;
using ServerLib.Model;

namespace ServerLib
{
    public class Program
    {
        public static SQLiteCommandRepository db;

        public static async void InitializeRepository()
        {
            List<Library> books;
            SQLiteCommandRepository commandRepo = Locator.Resolve<SQLiteCommandRepository>();
            await commandRepo.Initialize();
            db = commandRepo as SQLiteCommandRepository;
            try
            {
                
                books = await commandRepo.GetBooks() ?? new List<Library>();
                Console.WriteLine(books[0].iro); //teszt az adatbazisbol valo olvasashoz
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private static async void InitializeServerRepository()
        {
            ServerConnectionRepository connectRepo = Locator.Resolve<ServerConnectionRepository>();
            await connectRepo.StartServer();
        }

        public static void write()
        {
            
        }
        static void Main(string[] args)
        {
            Locator.Initialize();
            InitializeRepository();
            InitializeServerRepository();
            Console.WriteLine("initalized");
        }

    }
}
