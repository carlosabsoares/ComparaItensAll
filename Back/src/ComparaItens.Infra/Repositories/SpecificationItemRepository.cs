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
            return await _context.SpecificationItems.AsNoTracking().ToListAsync();
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