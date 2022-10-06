using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Graph;

namespace AuvoSelecao.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            ActivatorUtilities.CreateInstance<Startup>(host.Services);
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
          Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    //services.AddTransient<App>();
                });
    }
}
