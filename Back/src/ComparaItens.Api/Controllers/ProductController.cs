using ComparaItens.Domain.Commands;
using ComparaItens.Domain.Commands.Product;
using ComparaItens.Domain.Entities;
using ComparaItens.Domain.Handlers.Contracts;
using ComparaItens.Domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace ComparaItens.Api.Controllers
{
    [ApiController]
    [Route("v1/comparaItens")]
    public class ProductController : ControllerBase
    {
        private IHostingEnvironment _env;
        private readonly string _dir;

        private readonly string path = "Resources";

        private readonly string pathImage = "Images";
        private readonly string pathDocument = "Folders";


        public ProductController(IHostingEnvironment env)
        {
            _env = env;
            _dir = _env.ContentRootPath;
        }

        /// <summary>Adiciona produtos</summary>
        /// <returns>Retorna boolean indicando sucesso ou falha na operação</returns>
        [HttpPost("product/create")]
        //[Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<GenericCommandResult> PostManufacturer(
            [FromForm] ProductInsertCommand command,
            [FromServices] IHandler<ProductInsertCommand> handler)
        {
            return (GenericCommandResult)await handler.Handle(command);
        }

        /// <summary>Retorna lista de todos os produtos</summary>
        /// <returns>Retorna lista de todos os produtos</returns>
        [HttpDelete("product/delete")]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<GenericCommandResult> DeleteProduct(
            [FromQuery] int id,
            [FromServices] IHandler<ProductDeleteCommand> handler)
        {
            ProductDeleteCommand command = new ProductDeleteCommand(id);

            return (GenericCommandResult)await handler.Handle(command);
        }

        /// <summary>Altera fabricantes de produtos</summary>
        /// <returns>Retorna boolean indicando sucesso ou falha na operação</returns>
        [HttpPut("product/update")]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<GenericCommandResult> UpdateProduct(
            [FromBody] ProductUpdateCommand command,
            [FromServices] IHandler<ProductUpdateCommand> handler)
        {
            return (GenericCommandResult)await handler.Handle(command);
        }

        /// <summary>Retorna lista de todos os produtos</summary>
        /// <returns>Retorna lista de todos os produtos</returns>
        [HttpGet("product/findAll")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(IList<Product>), 200)]
        public async Task<IList<Product>> FindAllProduct(
            [FromServices] IProductRepository repository)
        {
            var result = await repository.FindAll();

            foreach (var item in result)
            {
                item.PathImage = GetPathImage(item.Image);
                item.PathFolder = GetPathFolder(item.Folder);
            }
            
            return result;
        }

        /// <summary>Retorna lista de todos os produtos</summary>
        /// <returns>Retorna lista de todos os produtos</returns>
        [HttpGet("product/findById")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(Product), 200)]
        public async Task<Product> FindById(
            [FromQuery] int id,
            [FromServices] IProductRepository repository)
        {
            var result = await repository.FindById(id);

            result.PathImage = GetPathImage(result.Image);
            result.PathFolder = GetPathFolder(result.PathFolder);
            return result;
        }

        private string GetPathImage(string nameImage)
        {
            return Path.Combine(_dir, path, pathImage, nameImage);
        }

        public string GetPathFolder(string nameFolder)
        {
            return Path.Combine(_dir, path, pathImage, nameFolder);
        }

        /// <summary>Retorna lista de todos os produtos</summary>
        /// <returns>Retorna lista de todos os produtos</returns>
        [HttpGet("product/findByParameters")]
        [ProducesResponseType(typeof(Product), 200)]
        public async Task<IList<Product>> FindByParameters(
            [FromQuery] int categoryId,
            [FromQuery] int manufacturerId,
            [FromQuery] int characteisticId,
            [FromQuery] string key,
            [FromQuery] string keyDescription,
            [FromQuery] string description,
            [FromServices] IProductRepository repository)
        {
            var result = await repository.FindByParameters(categoryId,
                                                                     manufacturerId,
                                                                     characteisticId,
                                                                     key,
                                                                     keyDescription,
                                                                     description);

            foreach (var item in result)
            {
                item.PathImage = GetPathImage(item.Image);
                item.PathFolder = GetPathFolder(item.Folder);
            }

            return result;
        }
    }
}