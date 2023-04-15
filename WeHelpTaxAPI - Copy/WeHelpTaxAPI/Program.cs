using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using System.IO;
using System.Xml;
using WeHelpTaxAPI.Models;
using WeHelpTaxAPI.Repository;
using Microsoft.EntityFrameworkCore;




namespace WeHelpTaxAPI
{
    public class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            var config = new ConfigurationBuilder()
            .SetBasePath(System.IO.Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            var log4netConfig = config.GetSection("Log4NetConfig");

            var repo = LogManager.CreateRepository(
                typeof(Program).Assembly,
                typeof(log4net.Repository.Hierarchy.Hierarchy));

            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(log4netConfig.GetValue<string>("Root"));

            XmlConfigurator.Configure(repo, xmlDocument.DocumentElement);

            log.Debug("Application started.");

            // ...

            log.Error("Something went wrong.");

            // ...

            log.Debug("Application ended.");

            LogManager.Shutdown();







          
            var optionsBuilder = new DbContextOptionsBuilder<taxPayerApplicationContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));

            var context = new taxPayerApplicationContext(optionsBuilder.Options);

            var jwtManagerRepository = new JWTManagerRepository(context, config);
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
