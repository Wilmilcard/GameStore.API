using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace GameStore.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            //BuildWebHost(args).Run();
        }

        // public static IWebHost BuildWebHost(string[] args) =>
        // WebHost.CreateDefaultBuilder(args)
        //.UseStartup<Startup>()
        //.UseKestrel(options =>
        //{
        //    options.Limits.MaxConcurrentConnections = 1000;
        //    options.Limits.MaxConcurrentUpgradedConnections = 1000;
        //    options.Limits.MaxRequestBodySize = 30000000;
        //    options.Limits.KeepAliveTimeout = new TimeSpan(2, 0, 0);
        //    options.Listen(IPAddress.Any, 5001);
        //})
        //.Build();


        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
