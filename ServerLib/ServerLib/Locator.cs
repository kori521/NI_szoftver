using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using ServerLib.Connections;

namespace ServerLib
{
    public class Locator
    {
        private static IServiceProvider serviceProvider;
        public static void Initialize()
        {
            var services = new ServiceCollection();
            services.AddSingleton<SQLiteCommandRepository, SQLiteConnection>();
            services.AddSingleton<ServerConnectionRepository, ServerConnection>();
            serviceProvider = services.BuildServiceProvider();
        }
        public static T Resolve<T>() => serviceProvider.GetService<T>();
    }
}
