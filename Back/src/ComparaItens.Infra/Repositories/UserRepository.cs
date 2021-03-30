using ComparaItens.Domain.Entities;
using ComparaItens.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComparaItens.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IList<User>> FindAll()
        {
            var query = _context.Users.AsNoTracking();

            return await query.Select(x => new User { Id = x.Id, Email = x.Email, Login = x.Login, Name = x.Name, Password = MaskedEmail(x.Password), Role = x.Role }).ToListAsync();

        }

        public async Task<User> FindById(string id)
        {
            var query = _context.Users.AsNoTracking();

            return await query.Where(x => x.Id.ToString() == id).FirstOrDefaultAsync();
        }

        public string MaskedEmail(string source)
        {
            if (string.IsNullOrEmpty(source))
                return source;

            int posEmailPre = source.IndexOf("@");

            string firstPosition = source.Substring(0, 1);
            string lastPosition = source.Substring((posEmailPre - 1), 1);

            string centerPosition = new string('*', (posEmailPre - 2));

            string emailComplemente = source.Substring(posEmailPre, (source.Length - posEmailPre));

            var maskedString = string.Concat(firstPosition, centerPosition, lastPosition, emailComplemente);
            return maskedString;
        }

        public async Task<User> VerifyUser(string login, string password)
        {
            var query = _context.Users.AsNoTracking();

            return await query.Where(x => x.Login == login && x.Password == password).Select( x=> new User { Id = x.Id, 
                                                                                                             Email = x.Email, 
                                                                                                             Login = x.Login, 
                                                                                                             Name = x.Name, 
                                                                                                             Role = x.Role
                                                                                                            }).FirstOrDefaultAsync();
        }
    }
}