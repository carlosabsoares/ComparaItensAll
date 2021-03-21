using ComparaItens.Domain.Repositories;
using ComparaItens.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ComparaItens.Api.DependencyMap
{
    public static class RepositoryDependencyMap
    {
        public static void RepositoryMap(this IServiceCollection services)
        {
            services.AddScoped<ICudRepository, CudRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IManufacturerRepository, ManufacturerRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}