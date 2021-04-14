using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComparaItens.Domain.Entities;

namespace ComparaItens.Domain.Repositories
{
    public interface ISpecificationCharacteristcRelRepository
    {
        Task<IList<SpecificationCharacteristcRel>> FindByCharacteristicDescriptionId(int idCharacteristicDescription);
        Task<IList<SpecificationCharacteristcRel>> FindBySpecificationItemId(int idSpecificationItem);

    }
}
