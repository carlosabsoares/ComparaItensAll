using ComparaItens.Domain.Commands;
using ComparaItens.Domain.Commands.Product;
using ComparaItens.Domain.Handlers;
using ComparaItens.Domain.Handlers.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace ComparaItens.Api.DependencyMap
{
    public static class HandlerDependencyMap
    {
        public static void HandlerMap(this IServiceCollection services)
        {
            //Category
            services.AddScoped<IHandler<CategoryInsertCommand>, CategoryHandler>();
            services.AddScoped<IHandler<CategoryDeleteCommand>, CategoryHandler>();
            services.AddScoped<IHandler<CategoryUpdateCommand>, CategoryHandler>();

            //Product
            services.AddScoped<IHandler<ProductInsertCommand>, ProductHandler>();
            services.AddScoped<IHandler<ProductDeleteCommand>, ProductHandler>();
            services.AddScoped<IHandler<ProductUpdateCommand>, ProductHandler>();

            //Manufacturer
            services.AddScoped<IHandler<ManufacturerInsertCommand>, ManufacturerHandler>();
            services.AddScoped<IHandler<ManufacturerDeleteCommand>, ManufacturerHandler>();
            services.AddScoped<IHandler<ManufacturerUpdateCommand>, ManufacturerHandler>();

            //User
            services.AddScoped<IHandler<UserInsertCommand>, UserHandler>();
            services.AddScoped<IHandler<UserUpdateCommand>, UserHandler>();
            services.AddScoped<IHandler<UserDeleteCommand>, UserHandler>();
            services.AddScoped<IHandler<UserValidateAccessCommand>, UserHandler>();

            //Characteiristc
            services.AddScoped<IHandler<CharacteristicInsertCommand>, CharacteristicHandler>();
            services.AddScoped<IHandler< CharacteristicDeleteCommand>, CharacteristicHandler>();
            services.AddScoped<IHandler<CharacteristicUpdateCommand>, CharacteristicHandler>();

            //CharacteiristcKey
            services.AddScoped<IHandler<CharacteristicKeyInsertCommand>, CharacteristicKeyHandler>();
            services.AddScoped<IHandler<CharacteristicKeyDeleteCommand>, CharacteristicKeyHandler>();
            services.AddScoped<IHandler<CharacteristicKeyUpdateCommand>, CharacteristicKeyHandler>();

            //CharacteiristcDescription
            services.AddScoped<IHandler<CharacteristicDescriptionInsertCommand>, CharacteristicDescriptionHandler>();
            services.AddScoped<IHandler<CharacteristicDescriptionDeleteCommand>, CharacteristicDescriptionHandler>();
            services.AddScoped<IHandler<CharacteristicDescriptionUpdateCommand>, CharacteristicDescriptionHandler>();


        }
    }
}