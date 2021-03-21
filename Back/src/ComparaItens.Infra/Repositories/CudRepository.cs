using ComparaItens.Domain.Repositories;
using System.Threading.Tasks;

namespace ComparaItens.Infra.Repositories
{
    public class CudRepository : ICudRepository
    {
        private readonly DataContext _context;

        public CudRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> Add<T>(T entity) where T : class
        {
            _context.Add(entity);
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<bool> Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<bool> Update<T>(T entity) where T : class
        {
            _context.Update(entity);
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}