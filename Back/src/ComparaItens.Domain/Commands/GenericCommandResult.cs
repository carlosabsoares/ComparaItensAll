using System.Net;

namespace ComparaItens.Domain.Commands
{
    public class GenericCommandResult : ICommandResult
    {
        public GenericCommandResult()
        {
        }

        public GenericCommandResult(bool success, HttpStatusCode code, object data)
        {
            Success = success;
            Code = code;
            Data = data;
        }

        public bool Success { get; set; }
        public HttpStatusCode Code { get; set; }
        public object Data { get; set; }
    }
}