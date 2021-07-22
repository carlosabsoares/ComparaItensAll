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
    public class CharacteristicKeyController : ControllerBase
    {
        /// <summary>Adiciona categoria de produtos</summary>
        /// <returns>Retorna boolean indicando sucesso ou falha na operação</returns>
        [HttpPost("characteristicKey/create")]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<GenericCommandResult> PostCharacteristic(
            [FromBody] CharacteristicKeyInsertCommand command,
            [FromServices] IHandler<CharacteristicKeyInsertCommand> handler)
        {
            return (GenericCommandResult)await handler.Handle(command);
        }

        /// <summary>Deleta categoria de produtos</summary>
        /// <returns>Retorna boolean indicando sucesso ou falha na operação</returns>
        [HttpDelete("characteristicKey/delete")]
        //[Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<GenericCommandResult> DeleteCharacteristic(
            //[FromBody] CategoryDeleteCommand command,
            [FromQuery] int id,
            [FromServices] IHandler<CharacteristicKeyDeleteCommand> handler)
        {
            var command = new CharacteristicKeyDeleteCommand(id);

            return (GenericCommandResult)await handler.Handle(command);
        }

        /// <summary>Altera categoria de produtos</summary>
        /// <returns>Retorna boolean indicando sucesso ou falha na operação</returns>
        [HttpPut("characteristicKey/update")]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<GenericCommandResult> UpdateCharacteristic(
            [FromBody] CharacteristicKeyUpdateCommand command,
            [FromServices] IHandler<CharacteristicKeyUpdateCommand> handler)
        {
            return (GenericCommandResult)await handler.Handle(command);
        }

        /// <summary>Retorna categorias de produtos</summary>
        /// <returns>Retorna categorias de produtos</returns>
        [HttpGet("characteristicKey/findAll")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(IList<CharacteristicKey>), 200)]
        public async Task<IList<CharacteristicKey>> FindAllCharacteristic(
            [FromServices] ICharacteristicKeyRepository repository)
        {
            var result = await repository.FindAll();

            return result;
        }

        /// <summary>Retorna categorias de produtos</summary>
        /// <returns>Retorna categorias de produtos</returns>
        [HttpGet("characteristicKey/findById")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(IList<CharacteristicKey>), 200)]
        public async Task<CharacteristicKey> FindByIdCharacteristic(
            [FromQuery] int id,
            [FromServices] ICharacteristicKeyRepository repository)
        {
            var result = await repository.FindById(id);

            return result;
        }

        /// <summary>Retorna categorias de produtos</summary>
        /// <returns>Retorna categorias de produtos</returns>
        [HttpGet("characteristicKey/findByDescription")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(IList<CharacteristicKey>), 200)]
        public async Task<IList<CharacteristicKey>> FindByDescription(
            [FromQuery] string description,
            [FromServices] ICharacteristicKeyRepository repository)
        {
            var result = await repository.FindByAllDescription(description);
            return result;
        }

        /// <summary>Retorna categorias de produtos</summary>
        /// <returns>Retorna categorias de produtos</returns>
        [HttpGet("characteristicKey/findByCharacteristcKey")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(IList<CharacteristicKey>), 200)]
        public async Task<IList<CharacteristicKey>> FindByCharacteristicId(
            [FromQuery] int characteristicId,
            [FromServices] ICharacteristicKeyRepository repository)
        {
            var result = await repository.FindByCharacteristicId(characteristicId);
            return result;
        }
    }

}