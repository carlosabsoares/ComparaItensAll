using ComparaItens.Domain.Commands;
using ComparaItens.Domain.Entities;
using ComparaItens.Domain.Handlers.Contracts;
using ComparaItens.Domain.Repositories;
using Flunt.Notifications;
using System.Net;
using System.Threading.Tasks;

namespace ComparaItens.Domain.Handlers
{
    public class CharacteristicHandler : Notifiable,
            IHandler<CharacteristicInsertCommand>,
            IHandler<CharacteristicDeleteCommand>,
            IHandler<CharacteristicUpdateCommand>
    {
        private readonly ICudRepository _cudRepository;
        private readonly ICharacteristicRepository _characteristicRepository;

        public CharacteristicHandler(ICudRepository cudRepository, ICharacteristicRepository characteristicRepository)
        {
            _cudRepository = cudRepository;
            _characteristicRepository = characteristicRepository;
        }

        public async Task<ICommandResult> Handle(CharacteristicInsertCommand command)
        {
            //FFV
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(
                            false,
                            HttpStatusCode.BadRequest,
                            command.Notifications);

            Characteristic _entity = new Characteristic();
            _entity.Description = command.Description;
            _entity.CategoryId = command.CategoryId;

            var _result = await _cudRepository.Add(_entity);

            //retorna o resultado
            if (!_result)
                return new GenericCommandResult(false, HttpStatusCode.BadRequest, _result);

            return new GenericCommandResult(true, HttpStatusCode.Created, _result);
        }

        public async Task<ICommandResult> Handle(CharacteristicDeleteCommand command)
        {
            //FFV
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(
                            false,
                            HttpStatusCode.BadRequest,
                            command.Notifications);

            var _verify = await _characteristicRepository.FindById(command.Id);

            if (_verify == null)
                return new GenericCommandResult(false, HttpStatusCode.NotFound, "Não localizado na base");

            Characteristic _entity = new Characteristic();
            _entity.Id = command.Id;

            var _result = await _cudRepository.Delete(_entity);

            //retorna o resultado
            if (!_result)
                return new GenericCommandResult(false, HttpStatusCode.BadRequest, _result);

            return new GenericCommandResult(true, HttpStatusCode.OK, _result);
        }

        public async Task<ICommandResult> Handle(CharacteristicUpdateCommand command)
        {
            //FFV
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(
                            false,
                            HttpStatusCode.BadRequest,
                            command.Notifications);

            var _verify = await _characteristicRepository.FindById(command.Id);

            if (_verify == null)
                return new GenericCommandResult(false, HttpStatusCode.NotFound, "Não localizado na base");

            Characteristic _entity = new Characteristic();
            _entity.Id = command.Id;
            _entity.Description = command.Description;
            _entity.CategoryId = command.CategoryId;

            var _result = await _cudRepository.Update(_entity);

            //retorna o resultado
            if (!_result)
                return new GenericCommandResult(false, HttpStatusCode.BadRequest, _result);

            return new GenericCommandResult(true, HttpStatusCode.OK, _result);
        }
    }
}