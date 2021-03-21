using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ComparaItens.Api.DependencyMap
{
    public static class ServiceDependencyMap
    {
        public static void ServiceMap(this IServiceCollection services, IConfiguration configuration)
        {
            // ----- SERVICES --------
            // Biblioteca para manipulação do JWT
            //services.AddScoped<IJwtService>(sp => new JwtService(configuration.GetValue<string>("APP_KEY")));
        }
    }
}