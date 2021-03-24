using ComparaItens.Domain.Entities;
using ComparaItens.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
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

            return await query.Select(x => new User { Id = x.Id, Email = x.Email, Login = x.Login, Name = x.Name, Password = x.Password, Role = x.Role }).ToListAsync();

        }

        public async Task<User> FindById(string id)
        {
            var query = _context.Users.AsNoTracking();

            return await query.Where(x => x.Id.ToString() == id).FirstOrDefaultAsync();
        }

        public async Task<User> VerifyUser(string login, string password)
        {
            var query = _context.Users.AsNoTracking();

            return await query.Where(x => x.Login == login && x.Password == password).FirstOrDefaultAsync();
        }
    }
}