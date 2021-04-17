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
    public class ProductItemController : ControllerBase
    {
        /// <summary>Retorna lista de todos os produtos</summary>
        /// <returns>Retorna lista de todos os produtos</returns>
        [HttpGet("productItem/findAll")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(IList<ProductItem>), 200)]
        public async Task<IList<ProductItem>> FindAllProduct(
            [FromServices] IProductItemRepository repository)
        {
            var result = await repository.FindAll();

            return result;
        }
    }
}