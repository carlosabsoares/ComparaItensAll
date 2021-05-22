﻿using ComparaItens.Domain.Commands;
using ComparaItens.Domain.Commands.Product;
using ComparaItens.Domain.Entities;
using ComparaItens.Domain.Handlers.Contracts;
using ComparaItens.Domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

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
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<GenericCommandResult> PostManufacturer(
            [FromBody] ProductInsertCommand command,
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

            return result;
        }

        [HttpGet("product/findById")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(Product), 200)]
        public async Task<Product> FindById(
            [FromQuery] int id,
            [FromServices] IProductRepository repository)
        {
            var result = await repository.FindById(id);

            return result;
        }

        private string GetPathImage(string nameImage)
        {
            var _result = Path.Combine(@"https://localhost:5001", path, pathImage, nameImage);

            _result = _result.Replace("\\", @"\");
            _result = _result.Replace("//", @"/");

            return _result;
        }

        private string GetPathFolder(string nameFolder)
        {
            var _result = Path.Combine(@"https://localhost:5001", path, pathDocument, nameFolder);

            _result = _result.Replace("\\", @"\");
            _result = _result.Replace("//", @"/");

            return _result;
        }

        /// <summary>Retorna lista de todos os produtos</summary>
        /// <returns>Retorna lista de todos os produtos</returns>
        [HttpGet("product/findByParameters")]
        [AllowAnonymous]
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

            return result;
        }
    }
}