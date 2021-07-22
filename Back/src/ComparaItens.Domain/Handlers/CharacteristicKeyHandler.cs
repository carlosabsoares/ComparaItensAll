using ComparaItens.Domain.Commands;
using ComparaItens.Domain.Entities;
using ComparaItens.Domain.Handlers.Contracts;
using ComparaItens.Domain.Repositories;
using Flunt.Notifications;
using System.Net;
using System.Threading.Tasks;

namespace ComparaItens.Domain.Handlers
{
    public class CharacteristicKeyHandler : Notifiable,
            IHandler<CharacteristicKeyInsertCommand>,
            IHandler<CharacteristicKeyDeleteCommand>,
            IHandler<CharacteristicKeyUpdateCommand>
    {
        private readonly ICudRepository _cudRepository;
        private readonly ICharacteristicKeyRepository _characteristicKeyRepository;

        public CharacteristicKeyHandler(ICudRepository cudRepository, ICharacteristicKeyRepository characteristicKeyRepository)
        {
            _cudRepository = cudRepository;
            _characteristicKeyRepository = characteristicKeyRepository;
        }

        public async Task<ICommandResult> Handle(CharacteristicKeyInsertCommand command)
        {
            //FFV
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(
                            false,
                            HttpStatusCode.BadRequest,
                            command.Notifications);

            var _entity = new CharacteristicKey
            {
                CharacteristicId = command.CharacteristicId,
                Description = command.Description
            };

            var _result = await _cudRepository.Add(_entity);

            //retorna o resultado
            if (!_result)
                return new GenericCommandResult(false, HttpStatusCode.BadRequest, _result);

            return new GenericCommandResult(true, HttpStatusCode.Created, _result);
        }

        public async Task<ICommandResult> Handle(CharacteristicKeyUpdateCommand command)
        {
            //FFV
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(
                            false,
                            HttpStatusCode.BadRequest,
                            command.Notifications);

            var _verify = await _characteristicKeyRepository.FindByIdTabela(command.Id);

            if (_verify == null)
                return new GenericCommandResult(false, HttpStatusCode.NotFound, "Não localizado na base");

            var _entity = new CharacteristicKey
            {
                Id = command.Id,
                CharacteristicId = command.characteristicId,
                Description = command.Description
            };

            var _result = await _cudRepository.Update(_entity);

            //retorna o resultado
            if (!_result)
                return new GenericCommandResult(false, HttpStatusCode.BadRequest, _result);

            return new GenericCommandResult(true, HttpStatusCode.OK, _result);
        }

        public async Task<ICommandResult> Handle(CharacteristicKeyDeleteCommand command)
        {
            //FFV
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(
                            false,
                            HttpStatusCode.BadRequest,
                            command.Notifications);

            var _verify = await _characteristicKeyRepository.FindByIdTabela(command.Id);

            if (_verify == null)
                return new GenericCommandResult(false, HttpStatusCode.NotFound, "Não localizado na base");

            var _entity = new CharacteristicKey
            {
                Id = command.Id
            };

            var _result = await _cudRepository.Delete(_entity);

            //retorna o resultado
            if (!_result)
                return new GenericCommandResult(false, HttpStatusCode.BadRequest, _result);

            return new GenericCommandResult(true, HttpStatusCode.OK, _result);
        }
    }
}