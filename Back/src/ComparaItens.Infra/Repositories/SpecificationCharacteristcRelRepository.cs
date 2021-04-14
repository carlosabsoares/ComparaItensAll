using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComparaItens.Domain.Entities;
using ComparaItens.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ComparaItens.Infra.Repositories
{
    public class SpecificationCharacteristcRelRepository : ISpecificationCharacteristcRelRepository
    {
        private readonly DataContext _context;

        public SpecificationCharacteristcRelRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IList<SpecificationCharacteristcRel>> FindByCharacteristicDescriptionId(int idCharacteristicDescription)
        {
            return await _context.SpecificationCharacteristcRels.AsNoTracking()
                .Where(x => x.CharacteristicDescriptionId == idCharacteristicDescription).ToListAsync();
        }

        public async Task<IList<SpecificationCharacteristcRel>> FindBySpecificationItemId(int idSpecificationItem)
        {
            return await _context.SpecificationCharacteristcRels.AsNoTracking()
                .Where(x => x.SpecificationItemId == idSpecificationItem).ToListAsync();
        }
    }
}
