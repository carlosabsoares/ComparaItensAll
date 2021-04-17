using ComparaItens.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComparaItens.Domain.Repositories
{
    public interface IProductItemRepository
    {
        Task<IList<ProductItem>> FindByProductId(int productId);

        Task<IList<ProductItem>> FindAll();
    }
}