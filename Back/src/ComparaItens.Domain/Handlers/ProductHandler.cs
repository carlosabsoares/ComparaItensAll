﻿using ComparaItens.Domain.Commands;
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
            _entity.ManufacturerId = command.ManufacturerId;
            _entity.Model = command.Model;
            _entity.CategoryId = command.CategoryId;
            _entity.YearOfManufacture = command.YearOfManufacture;
            _entity.Image = command.Image;
            _entity.Folder = command.Folder;
            _entity.CharacteristicDescriptions = command.CharacteristicDescriptions;

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

            Product product = new Product();
            product.Id = command.Id;

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

            Product product = new Product();
            product.Id = command.Id;
            product.Folder = command.Folder;
            product.CategoryId = command.CategoryId;
            product.Description = command.Description;
            product.Image = command.Image;
            product.ManufacturerId = command.ManufacturerId;
            product.YearOfManufacture = command.YearOfManufacture;
            product.Model = command.Model;
            product.CharacteristicDescriptions = command.CharacteristicDescriptions;

            var _result = await _productRepository.Update(product);

            //retorna o resultado
            if (!_result)
                return new GenericCommandResult(false, HttpStatusCode.BadRequest, _result);

            return new GenericCommandResult(true, HttpStatusCode.OK, _result);
            ;
        }
    }
}