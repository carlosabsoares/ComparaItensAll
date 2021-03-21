using ComparaItens.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComparaItens.Domain.Repositories
{
    public interface IManufacturerRepository
    {
        Task<Manufacturer> FindById(int id);

        Task<IList<Manufacturer>> FindAll();

        Task<Manufacturer> FindByDescription(string description);
    }
}