using ComparaItens.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComparaItens.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<Category> FindById(int id);

        Task<IList<Category>> FindAll();

        Task<Category> FindByDescription(string description);
    }
}