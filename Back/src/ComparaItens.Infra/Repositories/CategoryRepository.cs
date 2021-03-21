using ComparaItens.Domain.Entities;
using ComparaItens.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComparaItens.Infra.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;

        public CategoryRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IList<Category>> FindAll()
        {
            var query = _context.Categorys.AsNoTracking();

            return await query.ToListAsync();
        }

        public async Task<Category> FindByDescription(string description)
        {
            var query = _context.Categorys.AsNoTracking();

            return await query.Where(x => x.Description == description).FirstOrDefaultAsync();
        }

        public async Task<Category> FindById(int id)
        {
            var query = _context.Categorys.AsNoTracking();

            return await query.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}