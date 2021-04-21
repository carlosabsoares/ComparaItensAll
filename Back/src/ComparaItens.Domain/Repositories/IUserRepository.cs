using ComparaItens.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComparaItens.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<User> FindById(int id);

        Task<IList<User>> FindAll();

        Task<User> VerifyUser(string login, string password);
    }
}