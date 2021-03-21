using ComparaItens.Domain.Commands;
using ComparaItens.Domain.Commands.Product;
using ComparaItens.Domain.Entities;
using ComparaItens.Domain.Handlers.Contracts;
using ComparaItens.Domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComparaItens.Api.Controllers
{
    [ApiController]
    [Route("v1/comparaItens")]
    public class ProductController : ControllerBase
    {
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
            //[FromBody] CategoryDeleteCommand command,
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

        /// <summary>Retorna lista de todos os produtos</summary>
        /// <returns>Retorna lista de todos os produtos</returns>
        [HttpGet("product/findBySpecification")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(IList<Product>), 200)]
        public async Task<IList<Product>> FindBySpecificationProduct(
            [FromQuery] int categoryId,
            [FromQuery] string specification,
            [FromServices] IProductRepository repository)
        {
            var result = await repository.FindBySpecificationItem(categoryId, specification);

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

            return result;
        }

        /// <summary>Retorna lista de todos os produtos</summary>
        /// <returns>Retorna lista de todos os produtos</returns>
        [HttpGet("product/findByCategory")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(IList<Product>), 200)]
        public async Task<IList<Product>> FindByCategory(
            [FromQuery] int categoryId,
            [FromServices] IProductRepository repository)
        {
            var result = await repository.FindByCategory(categoryId);

            return result;
        }
    }
}