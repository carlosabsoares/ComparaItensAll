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
    public class CharacteristicDescriptionController : ControllerBase
    {
        /// <summary>Adiciona categoria de produtos</summary>
        /// <returns>Retorna boolean indicando sucesso ou falha na operação</returns>
        [HttpPost("characteristicDescription/create")]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<GenericCommandResult> PostCharacteristicDescription(
            [FromBody] CharacteristicDescriptionInsertCommand command,
            [FromServices] IHandler<CharacteristicDescriptionInsertCommand> handler)
        {
            return (GenericCommandResult)await handler.Handle(command);
        }

        /// <summary>Deleta categoria de produtos</summary>
        /// <returns>Retorna boolean indicando sucesso ou falha na operação</returns>
        [HttpDelete("characteristicDescription/delete")]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<GenericCommandResult> DeleteCharacteristicDescription(
            //[FromBody] CategoryDeleteCommand command,
            [FromQuery] int id,
            [FromServices] IHandler<CharacteristicDescriptionDeleteCommand> handler)
        {
            CharacteristicDescriptionDeleteCommand command = new CharacteristicDescriptionDeleteCommand(id);

            return (GenericCommandResult)await handler.Handle(command);
        }

        /// <summary>Altera categoria de produtos</summary>
        /// <returns>Retorna boolean indicando sucesso ou falha na operação</returns>
        [HttpPut("characteristicDescription/update")]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<GenericCommandResult> UpdateCharacteristicDescription(
            [FromBody] CharacteristicDescriptionUpdateCommand command,
            [FromServices] IHandler<CharacteristicDescriptionUpdateCommand> handler)
        {
            return (GenericCommandResult)await handler.Handle(command);
        }

        /// <summary>Retorna categorias de produtos</summary>
        /// <returns>Retorna categorias de produtos</returns>
        [HttpGet("characteristicDescription/findAll")]
        //[Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(IList<CharacteristicDescription>), 200)]
        public async Task<IList<CharacteristicDescription>> FindAllCharacteristicDescription(
            [FromServices] ICharacteristicDescriptionRepository repository)
        {
            var result = await repository.FindAll();

            return result;
        }

        /// <summary>Retorna categorias de produtos</summary>
        /// <returns>Retorna categorias de produtos</returns>
        [HttpGet("characteristicDescription/findAllById")]
        //[Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(IList<CharacteristicDescription>), 200)]
        public async Task<CharacteristicDescription> FindByIdCharacteristicDescription(
            [FromQuery] int id,
            [FromServices] ICharacteristicDescriptionRepository repository)
        {
            var result = await repository.FindById(id);

            return result;
        }
    }
}