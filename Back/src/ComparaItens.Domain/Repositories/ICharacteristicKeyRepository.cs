using ComparaItens.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComparaItens.Domain.Repositories
{
    public interface ICharacteristicKeyRepository
    {
        Task<CharacteristicKey> FindById(int id);

        Task<IList<CharacteristicKey>> FindAll();

        Task<CharacteristicKey> FindByDescription(string description);
    }
}