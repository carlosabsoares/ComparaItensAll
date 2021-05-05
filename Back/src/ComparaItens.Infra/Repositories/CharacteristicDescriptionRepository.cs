using ComparaItens.Domain.Entities;
using ComparaItens.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComparaItens.Infra.Repositories
{
    public class CharacteristicDescriptionRepository : ICharacteristicDescriptionRepository
    {
        private readonly DataContext _context;

        public CharacteristicDescriptionRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IList<CharacteristicDescription>> FindAll()
        {
            var query = _context.CharacteristicDescriptions.AsNoTracking()
                .Include(x => x.CharacteristicKeys)
                .Include(x => x.Characteristics);

            return await query.ToListAsync();
        }

        public Task<CharacteristicDescription> FindByDescription(string description)
        {
            throw new NotImplementedException();
        }

        public async Task<CharacteristicDescription> FindById(int id)
        {
            var query = _context.CharacteristicDescriptions.AsNoTracking();

            return await query.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IList<CharacteristicDescription>> FindByProductId(int idProduct)
        {
            var query = _context.CharacteristicDescriptions.AsNoTracking()
                .Include(x => x.CharacteristicKeys)
                .Include(x => x.Characteristics);

            return await query.Where(x => x.ProductId == idProduct).ToListAsync();
        }
    }
}