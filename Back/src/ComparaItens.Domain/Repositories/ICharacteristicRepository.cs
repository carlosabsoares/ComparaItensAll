using ComparaItens.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComparaItens.Domain.Repositories
{
    public interface ICharacteristicRepository
    {
        Task<Characteristic> FindById(int id);

        Task<IList<Characteristic>> FindAll();

        Task<Characteristic> FindByDescription(string description);
    }
}