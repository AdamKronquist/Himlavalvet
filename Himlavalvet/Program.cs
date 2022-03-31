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

        //Variabel som kollar om anv�ndaren �r inloggad. S�tts till true om inloggningen lyckas.
        //S�tts tillbaka till false om man loggar ut.
        public static bool signedIn = false;
        //Variabel som h�ller den inloggades anv�ndarnamn f�r att det ska kunna f�lja med p� flera sidor.
        public static string username = "";

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
