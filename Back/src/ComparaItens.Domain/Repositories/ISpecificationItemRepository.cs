using ComparaItens.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComparaItens.Domain.Repositories
{
    public interface ISpecificationItemRepository
    {
        Task<IList<SpecificationItem>> FindByProductId(int productId);

        Task<IList<SpecificationItem>> FindAll();

        Task<SpecificationItem> FindById(int id);
    }
}