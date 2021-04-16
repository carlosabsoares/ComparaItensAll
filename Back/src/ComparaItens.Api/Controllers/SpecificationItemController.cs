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
    public class SpecificationItemController : ControllerBase
    {
        /// <summary>Retorna lista de todos os produtos</summary>
        /// <returns>Retorna lista de todos os produtos</returns>
        [HttpGet("specificationItem/findAll")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(IList<SpecificationItem>), 200)]
        public async Task<IList<SpecificationItem>> FindAll(
            [FromServices] ISpecificationItemRepository repository)
        {
            return await repository.FindAll();
        }

        /// <summary>Retorna lista de todos os produtos</summary>
        /// <returns>Retorna lista de todos os produtos</returns>
        [HttpGet("specificationItem/findByProductId")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(IList<SpecificationItem>), 200)]
        public async Task<IList<SpecificationItem>> FindByProductId(
            [FromQuery] int productId,
            [FromServices] ISpecificationItemRepository repository)
        {
            return await repository.FindByProductId(productId);
        }

        /// <summary>Retorna lista de todos os produtos</summary>
        /// <returns>Retorna lista de todos os produtos</returns>
        [HttpGet("specificationItem/findById")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(IList<SpecificationItem>), 200)]
        public async Task<SpecificationItem> FindById(
            [FromQuery] int id,
            [FromServices] ISpecificationItemRepository repository)
        {
            return await repository.FindById(id);
        }
    }
}