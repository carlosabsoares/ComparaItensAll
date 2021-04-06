using ComparaItens.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparaItens.Infra.Repositories
{
    public class CharacteristicKey : ICharacteristicKey
    {
        private readonly DataContext _context;

        public CharacteristicKey(DataContext context)
        {
            _context = context;
        }

        public async Task<IList<CharacteristicKey>> FindAll()
        {
            var query = _context.CharacteristicKeys.AsNoTracking();

            return (IList<CharacteristicKey>)await query.ToListAsync();
        }

        public async Task<CharacteristicKey> FindByDescription(string description)
        {
            throw new NotImplementedException();
        }

        public async Task<CharacteristicKey> FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
