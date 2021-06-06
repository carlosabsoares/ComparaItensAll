using ComparaItens.Domain.Entities;
using ComparaItens.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComparaItens.Infra.Repositories
{
    public class CharacteristicRepository : ICharacteristicRepository
    {
        private readonly DataContext _context;

        public CharacteristicRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IList<Characteristic>> FindAll()
        {
            var query = _context.Characteristics
                .Include(x=> x.Category)
                .AsNoTracking();

            return await query.ToListAsync();
        }

        public async Task<Characteristic> FindByDescription(string description)
        {
            var query = _context.Characteristics
                .Include(x => x.Category)
                .AsNoTracking();

            return await query.Where(x => x.Description == description).FirstOrDefaultAsync();
        }

        public async Task<Characteristic> FindById(int id)
        {
            var query = _context.Characteristics
                .Include(x => x.Category)
                .AsNoTracking();

            return await query.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}