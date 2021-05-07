using ComparaItens.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComparaItens.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<bool> Add(Product entity);

        Task<bool> Update(Product entity);

        Task<bool> Delete(Product entity);

        Task<IList<Product>> FindAll();

        Task<Product> FindById(int id);

        Task<IList<Product>> FindByParameters(int categoryId, int manufacturerId, int characteisticId, string key, string keyDescription, string description);
    }
}