using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComparaItens.Domain.Entities;
using ComparaItens.Domain.Repositories;

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
    }
}
