using ComparaItens.Domain.Entities;
using ComparaItens.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComparaItens.Infra.Repositories
{
    public class ManufacturerRepository : IManufacturerRepository
    {
        private readonly DataContext _context;

        public ManufacturerRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IList<Manufacturer>> FindAll()
        {
            var query = _context.Manufacturers.AsNoTracking();

            return await query.ToListAsync();
        }

        public async Task<Manufacturer> FindByDescription(string description)
        {
            var query = _context.Manufacturers.AsNoTracking();

            return await query.Where(x => x.Description == description).FirstOrDefaultAsync();
        }

        public async Task<Manufacturer> FindById(int id)
        {
            var query = _context.Manufacturers.AsNoTracking();

            return await query.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}