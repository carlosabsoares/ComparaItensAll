using ComparaItens.Domain.Entities;
using ComparaItens.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComparaItens.Infra.Repositories
{
    public class CharacteristicKeyRepository : ICharacteristicKeyRepository
    {
        private readonly DataContext _context;

        public CharacteristicKeyRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IList<CharacteristicKey>> FindAll()
        {
            var query = _context.CharacteristicKeys.AsNoTracking();

            return await query.ToListAsync();
        }

        public async Task<CharacteristicKey> FindByDescription(string description)
        {
            var query = _context.CharacteristicKeys.AsNoTracking();

            return await query.Where(x => x.Description == description).FirstOrDefaultAsync();
        }

        public async Task<CharacteristicKey> FindById(int id)
        {
            var query = _context.CharacteristicKeys.AsNoTracking();

            return await query.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}