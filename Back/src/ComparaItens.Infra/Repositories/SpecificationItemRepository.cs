using ComparaItens.Domain.Entities;
using ComparaItens.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComparaItens.Infra.Repositories
{
    public class SpecificationItemRepository : ISpecificationItemRepository
    {
        private readonly DataContext _context;

        public SpecificationItemRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IList<SpecificationItem>> FindAll()
        {
            //return await _context.SpecificationItems.AsNoTracking().ToListAsync();

            var _return = await _context.SpecificationItems.AsNoTracking().ToListAsync();


            foreach (var item in _return)
            {
                item.SpecificationCharacteristcRels = await _context.SpecificationCharacteristcRels.AsNoTracking()
                    .Where(x => x.SpecificationItemId == item.Id).ToListAsync();
            }


            return _return;
            
        }

        public async Task<IList<SpecificationItem>> FindByProductId(int productId)
        {
            return await _context.SpecificationItems.AsNoTracking()
                .Where(x => x.ProductId == productId).ToListAsync();
        }

        public async Task<SpecificationItem> FindById(int id)
        {
            return await _context.SpecificationItems.AsNoTracking()
                .Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}