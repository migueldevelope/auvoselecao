using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Graph;

namespace AuvoSelecao.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
           /* var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (builder.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();*/

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
