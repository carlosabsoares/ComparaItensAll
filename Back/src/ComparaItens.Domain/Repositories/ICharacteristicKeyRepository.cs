using ComparaItens.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComparaItens.Domain.Repositories
{
    public interface ICharacteristicKeyRepository
    {
        Task<CharacteristicKey> FindById(int id);

        Task<CharacteristicKey> FindByIdTabela(int id);
        

        Task<IList<CharacteristicKey>> FindAll();

        Task<IList<CharacteristicKey>> FindByAllDescription(string key);

        Task<IList<CharacteristicKey>> FindByCharacteristicId(int characteristicId);
    }
}