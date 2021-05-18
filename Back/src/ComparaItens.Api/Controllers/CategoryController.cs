using ComparaItens.Domain.Commands;
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
    public class CategoryController : ControllerBase
    {
        /// <summary>Adiciona categoria de produtos</summary>
        /// <returns>Retorna boolean indicando sucesso ou falha na operação</returns>
        [HttpPost("category/create")]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<GenericCommandResult> PostCategory(
            [FromBody] CategoryInsertCommand command,
            [FromServices] IHandler<CategoryInsertCommand> handler)
        {
            return (GenericCommandResult)await handler.Handle(command);
        }

        /// <summary>Deleta categoria de produtos</summary>
        /// <returns>Retorna boolean indicando sucesso ou falha na operação</returns>
        [HttpDelete("category/delete")]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<GenericCommandResult> DeleteCategory(
            //[FromBody] CategoryDeleteCommand command,
            [FromQuery] int id,
            [FromServices] IHandler<CategoryDeleteCommand> handler)
        {
            CategoryDeleteCommand command = new CategoryDeleteCommand(id);

            return (GenericCommandResult)await handler.Handle(command);
        }

        /// <summary>Altera categoria de produtos</summary>
        /// <returns>Retorna boolean indicando sucesso ou falha na operação</returns>
        [HttpPut("category/update")]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<GenericCommandResult> UpdateCategory(
            [FromBody] CategoryUpdateCommand command,
            [FromServices] IHandler<CategoryUpdateCommand> handler)
        {
            return (GenericCommandResult)await handler.Handle(command);
        }

        /// <summary>Retorna categorias de produtos</summary>
        /// <returns>Retorna categorias de produtos</returns>
        [HttpGet("category/findAll")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(IList<Category>), 200)]
        public async Task<IList<Category>> FindAllCategory(
            [FromServices] ICategoryRepository repository)
        {
            var result = await repository.FindAll();

            return result;
        }

        /// <summary>Retorna categorias de produtos</summary>
        /// <returns>Retorna categorias de produtos</returns>
        [HttpGet("category/findById")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(IList<Category>), 200)]
        public async Task<Category> FindByIdCategory(
            [FromQuery] int id,
            [FromServices] ICategoryRepository repository)
        {
            var result = await repository.FindById(id);

            return result;
        }
    }
}