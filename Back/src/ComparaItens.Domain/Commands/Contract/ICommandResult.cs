using System.Net;

namespace ComparaItens.Domain.Commands
{
    public interface ICommandResult
    {
        bool Success { get; set; }
        HttpStatusCode Code { get; set; }
        object Data { get; set; }
    }
}