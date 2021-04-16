using ComparaItens.Domain.Commands;
using ComparaItens.Domain.Commands.Product;
using ComparaItens.Domain.Entities;
using ComparaItens.Domain.Handlers.Contracts;
using ComparaItens.Domain.Repositories;
using Flunt.Notifications;
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

        public ProductHandler(ICudRepository cudRepository, IProductRepository productRepository)
        {
            _cudRepository = cudRepository;
            _productRepository = productRepository;
        }

        public async Task<ICommandResult> Handle(ProductInsertCommand command)
        {
            //FFV
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, HttpStatusCode.BadRequest, command.Notifications);

            Product _entity = new Product();

            _entity.Description = command.Description;
            _entity.ManufecturerId = command.ManufecturerId;
            _entity.Model = command.Model;
            _entity.CategoryId = command.CategoryId;
            _entity.YearOfManufacture = command.YearOfManufacture;
            _entity.Image = command.Image;
            _entity.Folder = command.Folder;
            //_entity.SpecificationItems = command.SpecificationItems;

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

            var _verifyItens = await _productRepository.FindBySpecificationItem(command.Id);

            var _result = false;

            foreach (var item in _verifyItens)
            {
                SpecificationItem specificationItem = new SpecificationItem();
                specificationItem.Id = item.Id;
                specificationItem.ProductId = item.ProductId;
                //specificationItem.Description = item.Description;

                _result = await _cudRepository.Delete(specificationItem);
            }

            Product product = new Product();
            product.Id = _verify.Id;
            product.CategoryId = _verify.CategoryId;
            product.Description = _verify.Description;
            product.Folder = _verify.Folder;
            product.Image = _verify.Image;
            product.ManufecturerId = _verify.ManufecturerId;
            product.Model = _verify.Model;
            product.YearOfManufacture = _verify.YearOfManufacture;

            _result = await _cudRepository.Delete(product);

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

            Product _entity = new Product();

            _entity.Id = command.Id;
            _entity.Description = command.Description;
            _entity.ManufecturerId = command.ManufecturerId;
            _entity.Model = command.Model;
            _entity.CategoryId = command.CategoryId;
            _entity.YearOfManufacture = command.YearOfManufacture;
            _entity.Image = command.Image;
            _entity.Folder = command.Folder;

            var _verify = await _productRepository.FindById(command.Id);

            if (_verify == null)
                return new GenericCommandResult(false, HttpStatusCode.NotFound, "Não localizado na base");

            var _result = await _cudRepository.Update(_entity);

            var _verifyItem = await _productRepository.FindBySpecificationItem(_entity.Id);

            if (_verifyItem != null)
            {
                foreach (var item in _verifyItem)
                {
                    SpecificationItem specificationItem = new SpecificationItem();
                    specificationItem.Id = item.Id;
                    specificationItem.ProductId = item.ProductId;
                    //specificationItem.Description = item.Description;

                    await _cudRepository.Delete(specificationItem);
                }
            }

            foreach (var item in command.SpecificationItems)
            {
                SpecificationItem specificationItem = new SpecificationItem();
                specificationItem.ProductId = item.ProductId;
                //specificationItem.Description = item.Description;

                await _cudRepository.Add(specificationItem);
            }

            //retorna o resultado
            if (!_result)
                return new GenericCommandResult(false, HttpStatusCode.BadRequest, _result);

            return new GenericCommandResult(true, HttpStatusCode.OK, _result);
        }
    }
}