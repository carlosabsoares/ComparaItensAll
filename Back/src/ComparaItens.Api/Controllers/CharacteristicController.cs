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
    public class CharacteristicController : ControllerBase
    {
        /// <summary>Adiciona categoria de produtos</summary>
        /// <returns>Retorna boolean indicando sucesso ou falha na operação</returns>
        [HttpPost("characteristic/create")]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<GenericCommandResult> PostCharacteristic(
            [FromBody] CharacteristicInsertCommand command,
            [FromServices] IHandler<CharacteristicInsertCommand> handler)
        {
            return (GenericCommandResult)await handler.Handle(command);
        }

        /// <summary>Deleta categoria de produtos</summary>
        /// <returns>Retorna boolean indicando sucesso ou falha na operação</returns>
        [HttpDelete("characteristic/delete")]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<GenericCommandResult> DeleteCharacteristic(
            //[FromBody] CategoryDeleteCommand command,
            [FromQuery] int id,
            [FromServices] IHandler<CharacteristicDeleteCommand> handler)
        {
            CharacteristicDeleteCommand command = new CharacteristicDeleteCommand(id);

            return (GenericCommandResult)await handler.Handle(command);
        }

        /// <summary>Altera categoria de produtos</summary>
        /// <returns>Retorna boolean indicando sucesso ou falha na operação</returns>
        [HttpPut("characteristic/update")]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<GenericCommandResult> UpdateCharacteristic(
            [FromBody] CharacteristicUpdateCommand command,
            [FromServices] IHandler<CharacteristicUpdateCommand> handler)
        {
            return (GenericCommandResult)await handler.Handle(command);
        }

        /// <summary>Retorna categorias de produtos</summary>
        /// <returns>Retorna categorias de produtos</returns>
        [HttpGet("characteristic/findAll")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(IList<Characteristic>), 200)]
        public async Task<IList<Characteristic>> FindAllCharacteristic(
            [FromServices] ICharacteristicRepository repository)
        {
            var result = await repository.FindAll();

            return result;
        }

        /// <summary>Retorna categorias de produtos</summary>
        /// <returns>Retorna categorias de produtos</returns>
        [HttpGet("characteristic/findById")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(IList<Characteristic>), 200)]
        public async Task<Characteristic> FindByIdCharacteristic(
            [FromQuery] int id,
            [FromServices] ICharacteristicRepository repository)
        {
            var result = await repository.FindById(id);

            return result;
        }
    }
}