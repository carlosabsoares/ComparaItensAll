using ComparaItens.Domain.Entities;
using ComparaItens.Domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComparaItens.Api.Controllers
{
    [ApiController]
    [Route("v1/comparaItens")]
    public class SpecificationCharacteristcRelController : ControllerBase
    {
        /// <summary>Retorna lista de todos os produtos</summary>
        /// <returns>Retorna lista de todos os produtos</returns>
        [HttpGet("SpecificationCharacteristcRel/findBySpecificationItemId")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(IList<SpecificationCharacteristcRel>), 200)]
        public async Task<IList<SpecificationCharacteristcRel>> FindBySpecificationItemId(
            [FromQuery] int SpecificationItemId,
            [FromServices] ISpecificationCharacteristcRelRepository repository)
        {
            var result = await repository.FindBySpecificationItemId(SpecificationItemId);

            return result;
        }

        /// <summary>Retorna lista de todos os produtos</summary>
        /// <returns>Retorna lista de todos os produtos</returns>
        [HttpGet("SpecificationCharacteristcRel/findByCharacteristicDescriptionId")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(IList<SpecificationCharacteristcRel>), 200)]
        public async Task<IList<SpecificationCharacteristcRel>> FindByCharacteristicDescriptionId(
            [FromQuery] int CharacteristicDescriptionId,
            [FromServices] ISpecificationCharacteristcRelRepository repository)
        {
            var result = await repository.FindByCharacteristicDescriptionId(CharacteristicDescriptionId);

            return result;
        }
    }
}