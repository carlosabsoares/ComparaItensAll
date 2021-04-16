using ComparaItens.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComparaItens.Domain.Repositories
{
    public interface ISpecificationCharacteristcRelRepository
    {
        Task<IList<SpecificationCharacteristcRel>> FindByCharacteristicDescriptionId(int idCharacteristicDescription);

        Task<IList<SpecificationCharacteristcRel>> FindBySpecificationItemId(int idSpecificationItem);
    }
}