using ComparaItens.Domain.Commands;
using ComparaItens.Domain.Entities;
using ComparaItens.Domain.Handlers.Contracts;
using ComparaItens.Domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComparaItens.Api.Controllers
{
    [ApiController]
    [Route("v1/comparaItens")]
    public class UserController : ControllerBase
    {
        /// <summary>Adiciona usuario de administração</summary>
        /// <returns>Retorna boolean indicando sucesso ou falha na operação</returns>
        [HttpPost("user/create")]
        //[Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<GenericCommandResult> PostUser(
            [FromBody] UserInsertCommand command,
            [FromServices] IHandler<UserInsertCommand> handler)
        {
            return (GenericCommandResult)await handler.Handle(command);
        }

        /// <summary>Deleta usuario de administração</summary>
        /// <returns>Retorna boolean indicando sucesso ou falha na operação</returns>
        [HttpDelete("user/delete")]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<GenericCommandResult> DeleteUser(
            //[FromBody] CategoryDeleteCommand command,
            [FromQuery] string id,
            [FromServices] IHandler<UserDeleteCommand> handler)
        {
            UserDeleteCommand command = new UserDeleteCommand(id);

            return (GenericCommandResult)await handler.Handle(command);
        }

        /// <summary>Altera usuario de administração</summary>
        /// <returns>Retorna boolean indicando sucesso ou falha na operação</returns>
        [HttpPut("user/update")]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<GenericCommandResult> UpdateUser(
            [FromBody] UserUpdateCommand command,
            [FromServices] IHandler<UserUpdateCommand> handler)
        {
            return (GenericCommandResult)await handler.Handle(command);
        }

        /// <summary>Retorna usuário de administração</summary>
        /// <returns>Retorna usuário de administração</returns>
        [HttpGet("user/findAll")]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(typeof(IList<User>), 200)]
        public async Task<IList<User>> FindAllUser(
            [FromServices] IUserRepository repository)
        {
            var result = await repository.FindAll();

            return result;
        }

        /// <summary>Valida Acesso de usúário de administração</summary>
        /// <returns>Valida Acesso de usúário de administração</returns>
        [HttpPost("user/validateUser")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(User), 200)]
        public async Task<GenericCommandResult> ValidateAccess(
            [FromBody] UserValidateAccessCommand command,
            [FromServices] IHandler<UserValidateAccessCommand> handler
            )
        {
            return (GenericCommandResult)await handler.Handle(command);
        }
    }
}