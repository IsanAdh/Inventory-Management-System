using KTMPos.BAL;
using KTMPos.DAL;
using KTMPos.Desktop.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using System.Reflection;
using System.Web;

namespace KTMPos.Desktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            var host=CreateHostBuilder(args).Build();
            var serviceProvider = host.Services;
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(serviceProvider.GetRequiredService<LoginForm>());
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    config.SetBasePath(Directory.GetCurrentDirectory());
                    config.AddJsonFile("appsetting.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((hostingContext, services) =>
                {
                    var configuration = hostingContext.Configuration;
                    string connectionString = configuration.GetConnectionString("DefaultConnection");
                    services.AddDataAccessLayer(connectionString);
                    services.AddBusinessLayer();
                    //unnecessary services haru lai register garna nadina ko laagi chai tala ko "if" block.
                    if (Assembly.GetEntryAssembly()?.GetName().Name != "ef")
                    {
                        services.AddPresentationLayer(configuration);
                    }
                });
    }
}