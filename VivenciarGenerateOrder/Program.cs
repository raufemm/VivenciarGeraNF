using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;
using VivenciarGenerateOrder.Infra.Context;
using VivenciarGenerateOrder.Infra.IRepository;
using VivenciarGenerateOrder.Infra.Repository;

namespace VivenciarGeraNF
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<Form1>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
                    services.AddTransient<IProfessionalRepository, ProfessionalRepository>();
                    services.AddTransient<IPatientRepository, PatientRepository>();
                    services.AddTransient<IUnitOfWork, UnitOfWork>();
                    services.AddTransient<Form1>();
                });
        }
    }
}
