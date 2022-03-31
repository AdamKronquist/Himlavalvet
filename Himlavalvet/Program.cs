using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Himlavalvet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        //Variabel som kollar om användaren är inloggad. Sätts till true om inloggningen lyckas.
        //Sätts tillbaka till false om man loggar ut.
        public static bool signedIn = false;
        //Variabel som håller den inloggades användarnamn för att det ska kunna följa med på flera sidor.
        public static string username = "";

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
