using ComparaItens.Domain.Commands;
using System.Threading.Tasks;

namespace ComparaItens.Domain.Handlers.Contracts
{
    public interface IHandler<T> where T : ICommand
    {
        Task<ICommandResult> Handle(T command);
    }
}