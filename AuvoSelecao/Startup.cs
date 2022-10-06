using AuvoSelecao.Core.Interfaces;
using AuvoSelecao.Data;
using AuvoSelecao.Services.Business;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuvoSelecao.Startup))]
namespace AuvoSelecao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

        public void ConfigureAuth(IAppBuilder app)
        {
            
        }
        public void RegistreServices(IServiceCollection services)
        {
            string ipServidor = "Server=45.231.132.153;Database=PrevisaoClimaSimples;User Id=sa;Password=Bti9010;";

            services.AddScoped<DataContext>(_ => new DataContext(ipServidor));

            services.AddScoped<IServiceCidade, ServiceCidade>();
            services.AddScoped<IServicePrevisaoClima, ServicePrevisaoClima>();
            //services.AddScoped<IServicePrevisaoClima>(_ => new ServicePrevisaoClima(_context));
        }
    }
}
