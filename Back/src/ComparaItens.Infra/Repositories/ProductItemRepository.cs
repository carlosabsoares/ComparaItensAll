using ComparaItens.Domain.Entities;
using ComparaItens.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComparaItens.Infra.Repositories
{
    public class ProductItemRepository : IProductItemRepository
    {
        private readonly DataContext _context;

        public ProductItemRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IList<ProductItem>> FindAll()
        {
            return await _context.ProductItens
                .Include(x => x.CharacteristicDescription)
                .Include(x => x.CharacteristicDescription.CharacteristicKeys)
                .Include(x => x.CharacteristicDescription.Characteristics)
                .ToListAsync();
        }

        public async Task<IList<ProductItem>> FindByProductId(int productId)
        {
            return await _context.ProductItens
                .Include(x => x.CharacteristicDescription)
                .Include(x => x.CharacteristicDescription.CharacteristicKeys)
                .Include(x => x.CharacteristicDescription.Characteristics)
                .Where(x => x.ProductId == productId)
                .ToListAsync();
        }
    }
}