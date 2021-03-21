using ComparaItens.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComparaItens.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<User> FindById(string id);

        Task<IList<User>> FindAll();

        Task<User> VerifyUser(string login, string password);
    }
}