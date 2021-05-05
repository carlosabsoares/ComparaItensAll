using ComparaItens.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComparaItens.Domain.Repositories
{
    public interface ICharacteristicDescriptionRepository
    {
        Task<CharacteristicDescription> FindById(int id);

        Task<IList<CharacteristicDescription>> FindAll();

        Task<CharacteristicDescription> FindByDescription(string description);

        Task<IList<CharacteristicDescription>> FindByProductId(int idProduct);
    }
}