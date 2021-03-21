using ComparaItens.Domain.Commands;
using ComparaItens.Domain.Entities;
using ComparaItens.Domain.Handlers.Contracts;
using ComparaItens.Domain.Repositories;
using Flunt.Notifications;
using System.Net;
using System.Threading.Tasks;

namespace ComparaItens.Domain.Handlers
{
    public class ManufacturerHandler :
                    Notifiable,
                    IHandler<ManufacturerInsertCommand>,
                    IHandler<ManufacturerDeleteCommand>,
                    IHandler<ManufacturerUpdateCommand>
    {
        private readonly ICudRepository _cudRepository;
        private readonly IManufacturerRepository _manufactoryRepository;

        public ManufacturerHandler(ICudRepository cudRepository, IManufacturerRepository manufactoryRepository)
        {
            _cudRepository = cudRepository;
            _manufactoryRepository = manufactoryRepository;
        }

        public async Task<ICommandResult> Handle(ManufacturerInsertCommand command)
        {
            //FFV
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(
                            false,
                            HttpStatusCode.BadRequest,
                            command.Notifications);

            Manufacturer _entity = new Manufacturer(command.Description);

            var _result = await _cudRepository.Add(_entity);

            //retorna o resultado
            if (!_result)
                return new GenericCommandResult(false, HttpStatusCode.BadRequest, _result);

            return new GenericCommandResult(true, HttpStatusCode.Created, _result);
        }

        public async Task<ICommandResult> Handle(ManufacturerDeleteCommand command)
        {
            //FFV
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(
                            false,
                            HttpStatusCode.BadRequest,
                            command.Notifications);

            var _verify = await _manufactoryRepository.FindById(command.Id);

            if (_verify == null)
                return new GenericCommandResult(false, HttpStatusCode.NotFound, "Não localizado na base");

            Manufacturer _entity = new Manufacturer(command.Id);

            var _result = await _cudRepository.Delete(_entity);

            //retorna o resultado
            if (!_result)
                return new GenericCommandResult(false, HttpStatusCode.BadRequest, _result);

            return new GenericCommandResult(true, HttpStatusCode.OK, _result);
        }

        public async Task<ICommandResult> Handle(ManufacturerUpdateCommand command)
        {
            //FFV
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(
                            false,
                            HttpStatusCode.BadRequest,
                            command.Notifications);

            var _verify = await _manufactoryRepository.FindById(command.Id);

            if (_verify == null)
                return new GenericCommandResult(false, HttpStatusCode.NotFound, "Não localizado na base");

            Manufacturer _entity = new Manufacturer(command.Id, command.Description);

            var _result = await _cudRepository.Update(_entity);

            //retorna o resultado
            if (!_result)
                return new GenericCommandResult(false, HttpStatusCode.BadRequest, _result);

            return new GenericCommandResult(true, HttpStatusCode.OK, _result);
        }
    }
}