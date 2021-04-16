using ComparaItens.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComparaItens.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<Product> FindById(int id);

        Task<bool> Add(Product entity);

        Task<IList<Product>> FindAll();

        Task<IList<Product>> FindBySpecificationItem(int categoryId, string description);

        Task<IList<SpecificationItem>> FindBySpecificationItem(int productId);

        Task<IList<Product>> FindByCategory(int category);
    }
}