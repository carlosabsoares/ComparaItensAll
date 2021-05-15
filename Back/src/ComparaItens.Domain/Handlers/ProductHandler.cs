using ComparaItens.Domain.Commands;
using ComparaItens.Domain.Commands.Product;
using ComparaItens.Domain.Entities;
using ComparaItens.Domain.Handlers.Contracts;
using ComparaItens.Domain.Repositories;
using Flunt.Notifications;
using Microsoft.AspNetCore.Hosting;
using System.IO;
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

        private IHostingEnvironment _env;
        private readonly string _dir;

        private readonly string path = "Resources";
        
        private readonly string pathImage = "Images";
        private readonly string pathDocument = "Folders";



        public ProductHandler(ICudRepository cudRepository, IProductRepository productRepository, IHostingEnvironment env)
        {
            _cudRepository = cudRepository;
            _productRepository = productRepository;
            _env = env;
            _dir = _env.ContentRootPath;
        }

        public async Task<ICommandResult> Handle(ProductInsertCommand command)
        {
            //FFV
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, HttpStatusCode.BadRequest, command.Notifications);

            //Se houver arquivo anexado, gravar na diretório
            if (!string.IsNullOrEmpty(command.Image.FileName))
            {
                string fullPathImage = Path.Combine(_dir, path, pathImage);

                using (var fileStream = new FileStream(Path.Combine(fullPathImage, command.Image.FileName), FileMode.Create, FileAccess.Write))
                {
                    command.Image.CopyTo(fileStream);
                }
            }

            if (!string.IsNullOrEmpty(command.Folder.FileName))
            {
                string fullPathDocument = Path.Combine(_dir, path, pathDocument);

                using (var fileStream = new FileStream(Path.Combine(fullPathDocument, command.Folder.FileName), FileMode.Create, FileAccess.Write))
                {
                    command.Folder.CopyTo(fileStream);
                }
            }

            Product _entity = new Product();
            _entity.Description = command.Description;
            _entity.ManufacturerId = command.ManufacturerId;
            _entity.Model = command.Model;
            _entity.CategoryId = command.CategoryId;
            _entity.YearOfManufacture = command.YearOfManufacture;
            _entity.Image = command.Image.FileName;
            _entity.Folder = command.Folder.FileName;
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

            //Se houver arquivo anexado, gravar na diretório
            if (!string.IsNullOrEmpty(_verify.Image))
            {
                string fullPathImage = Path.Combine(_dir, path, pathImage, pathImage);

                string[] imageFile = Directory.GetFiles(fullPathImage, _verify.Image);

                foreach (var item in imageFile)
                {
                    File.Delete(item);
                }
            }

            if (!string.IsNullOrEmpty(_verify.Folder))
            {
                string fullPathDocument = Path.Combine(_dir, path, pathImage, pathDocument);

                string[] imageFolder = Directory.GetFiles(fullPathDocument, _verify.Folder);

                foreach (var item in imageFolder)
                {
                    File.Delete(item);
                }
            }

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

            //Se houver arquivo anexado, gravar na diretório
            if (!string.IsNullOrEmpty(command.Image.FileName))
            {
                string fullPathImage = Path.Combine(_dir, path, pathImage, pathImage);

                using (var fileStream = new FileStream(Path.Combine(fullPathImage, command.Image.FileName), FileMode.Create, FileAccess.Write))
                {
                    command.Image.CopyTo(fileStream);
                }
            }

            if (!string.IsNullOrEmpty(command.Folder.FileName))
            {
                string fullPathDocument = Path.Combine(_dir, path, pathImage, pathDocument);

                using (var fileStream = new FileStream(Path.Combine(fullPathDocument, command.Folder.FileName), FileMode.Create, FileAccess.Write))
                {
                    command.Folder.CopyTo(fileStream);
                }
            }

            Product product = new Product();
            product.Id = command.Id;
            product.Folder = command.Folder.FileName;
            product.CategoryId = command.CategoryId;
            product.Description = command.Description;
            product.Image = command.Image.FileName;
            product.ManufacturerId = command.ManufacturerId;
            product.YearOfManufacture = command.YearOfManufacture;
            product.Model = command.Model;
            product.CharacteristicDescriptions = command.CharacteristicDescriptions;

            var _result = await _productRepository.Update(product);

            //retorna o resultado
            if (!_result)
                return new GenericCommandResult(false, HttpStatusCode.BadRequest, _result);

            return new GenericCommandResult(true, HttpStatusCode.OK, _result);
        }
    }
}