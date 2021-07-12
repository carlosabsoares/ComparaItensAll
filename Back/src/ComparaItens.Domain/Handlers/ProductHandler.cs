using ComparaItens.Domain.Commands;
using ComparaItens.Domain.Commands.Product;
using ComparaItens.Domain.Entities;
using ComparaItens.Domain.Handlers.Contracts;
using ComparaItens.Domain.Repositories;
using Flunt.Notifications;
using Microsoft.AspNetCore.Hosting;
using System.Net;
using System.Threading.Tasks;

namespace ComparaItens.Domain.Handlers
{
    public class ProductHandler : Notifiable,
        IHandler<ProductInsertCommand>,
        IHandler<ProductDeleteCommand>,
        IHandler<ProductUpdateCommand>
    {
        private readonly ICudRepository _cudRepository;
        private readonly IProductRepository _productRepository;

        private readonly IHostingEnvironment _env;


        public ProductHandler(ICudRepository cudRepository, IProductRepository productRepository, IHostingEnvironment env)
        {
            _cudRepository = cudRepository;
            _productRepository = productRepository;
            _env = env;
        }

        public async Task<ICommandResult> Handle(ProductInsertCommand command)
        {
            //FFV
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, HttpStatusCode.BadRequest, command.Notifications);


            var _entity = new Product
            {
                Description = command.Description,
                ManufacturerId = command.ManufacturerId,
                Model = command.Model,
                CategoryId = command.CategoryId,
                YearOfManufacture = command.YearOfManufacture,
                CharacteristicDescriptions = command.CharacteristicDescriptions
            };

            var _result = await _productRepository.Add(_entity);

            //retorna o resultado
            if (!_result)
                return new GenericCommandResult(false, HttpStatusCode.BadRequest, _result);

            return new GenericCommandResult(true, HttpStatusCode.Created, _result);
        }

        public async Task<ICommandResult> Handle(ProductDeleteCommand command)
        {
            //FFV
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(
                    false,
                    HttpStatusCode.BadRequest,
                    command.Notifications);

            var _verify = await _productRepository.FindById(command.Id);

            if (_verify == null)
                return new GenericCommandResult(false, HttpStatusCode.NotFound, "Não localizado na base");

            var product = new Product
            {
                Id = command.Id
            };

            var _result = await _productRepository.Delete(product);

            //retorna o resultado
            if (!_result)
                return new GenericCommandResult(false, HttpStatusCode.BadRequest, _result);

            return new GenericCommandResult(true, HttpStatusCode.OK, _result);
        }

        public async Task<ICommandResult> Handle(ProductUpdateCommand command)
        {
            //FFV
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(
                    false,
                    HttpStatusCode.BadRequest,
                    command.Notifications);

            var _verify = await _productRepository.FindById(command.Id);

            if (_verify == null)
                return new GenericCommandResult(false, HttpStatusCode.NotFound, "Não localizado na base");

            var product = new Product
            {
                Id = command.Id,
                CategoryId = command.CategoryId,
                Description = command.Description,
                ManufacturerId = command.ManufacturerId,
                YearOfManufacture = command.YearOfManufacture,
                Model = command.Model,
                CharacteristicDescriptions = command.CharacteristicDescriptions
            };

            var _result = await _productRepository.Update(product);

            //retorna o resultado
            if (!_result)
                return new GenericCommandResult(false, HttpStatusCode.BadRequest, _result);

            return new GenericCommandResult(true, HttpStatusCode.OK, _result);
        }
    }
}