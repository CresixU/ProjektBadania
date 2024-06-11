using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjektBadania.Infrastructure;

namespace ProjektBadania
{
    public static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            var host = CreateHostBuilder();
            ServiceProvider = host.Services;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(ServiceProvider.GetRequiredService<Form1>());
        }

        private static IHost CreateHostBuilder()
        {
            var builder = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<Form1>();

                    services.AddDbContext<ExaminationsContext>(options => 
                        //options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ExaminationsProject;Trusted_Connection=True;Encrypt=False;")
                        options.UseSqlite("Data Source=examinations1.db")
                    );
                });


            return builder.Build();
        }
    }
}