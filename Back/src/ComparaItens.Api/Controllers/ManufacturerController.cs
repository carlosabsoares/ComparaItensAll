using ComparaItens.Domain.Commands;
using ComparaItens.Domain.Entities;
using ComparaItens.Domain.Handlers.Contracts;
using ComparaItens.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace ComparaItens.Api.Controllers
{
    [ApiController]
    [Route("v1/comparaItens")]
    public class ManufacturerController : ControllerBase
    {
        /// <summary>Adiciona fabricantes de produtos</summary>
        /// <returns>Retorna boolean indicando sucesso ou falha na operação</returns>
        [HttpPost("manufacturer/create")]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<GenericCommandResult> PostManufacturer(
            [FromBody] ManufacturerInsertCommand command,
            [FromServices] IHandler<ManufacturerInsertCommand> handler)
        {
            return (GenericCommandResult)await handler.Handle(command);
        }

        /// <summary>Deleta fabricantes de produtos</summary>
        /// <returns>Retorna boolean indicando sucesso ou falha na operação</returns>
        [HttpDelete("manufacturer/delete")]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<GenericCommandResult> DeleteManufacturer(
            //[FromBody] CategoryDeleteCommand command,
            [FromQuery] int id,
            [FromServices] IHandler<ManufacturerDeleteCommand> handler)
        {
            ManufacturerDeleteCommand command = new ManufacturerDeleteCommand(id);

            return (GenericCommandResult)await handler.Handle(command);
        }

        /// <summary>Altera fabricantes de produtos</summary>
        /// <returns>Retorna boolean indicando sucesso ou falha na operação</returns>
        [HttpPut("manufacturer/update")]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<GenericCommandResult> UpdateManufacturer(
            [FromBody] ManufacturerUpdateCommand command,
            [FromServices] IHandler<ManufacturerUpdateCommand> handler)
        {
            return (GenericCommandResult)await handler.Handle(command);
        }

        /// <summary>Retorna fabricantes de produtos</summary>
        /// <returns>Retorna fabricantes de produtos</returns>
        [HttpGet("manufacturer/findAll")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(IList<Manufacturer>), 200)]
        public async Task<IList<Manufacturer>> FindAllManufacturer(
            [FromServices] IManufacturerRepository repository)
        {
            var result = await repository.FindAll();

            return result;
        }

        /// <summary>Retorna fabricantes de produtos</summary>
        /// <returns>Retorna fabricantes de produtos</returns>
        [HttpGet("manufacturer/findById")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(IList<Manufacturer>), 200)]
        public async Task<Manufacturer> FindByIdManufacturer(
            [FromQuery] int id,
            [FromServices] IManufacturerRepository repository)
        {
            var result = await repository.FindById(id);

            return result;
        }
    }
}