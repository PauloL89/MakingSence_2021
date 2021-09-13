using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RentaCar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        //.ConfigureAppConfiguration((hostingContext, configuration)=> 
        //        {
        //            configuration.Sources.Clear();
        //            IHostEnvironment env = hostingContext.HostingEnvironment;

        //            configuration
        //                .AddJsonFile("appsettings.json", optional: true, reloadOnChange:true)
        //                .AddJsonFile($"appsettings.{env.EnvironmentName}.json",true,true);

        //            IConfigurationRoot configurationRoot = configuration.Build();
        //            Car car = new();
        //            configurationRoot.GetSection(nameof(Car)).Bind(car);
        //        });
    }
}
