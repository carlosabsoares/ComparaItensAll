﻿using ComparaItens.Domain.Commands;
using ComparaItens.Domain.Entities;
using ComparaItens.Domain.Handlers.Contracts;
using ComparaItens.Domain.Repositories;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ComparaItens.Domain.Handlers
{
    public class CharacteristicDescriptionHandler : Notifiable,
            IHandler<CharacteristicDescriptionInsertCommand>,
            IHandler<CharacteristicDescriptionDeleteCommand>,
            IHandler<CharacteristicDescriptionUpdateCommand>
    {
        private readonly ICudRepository _cudRepository;
        private readonly ICharacteristicDescriptionRepository _characteristicDescriptionRepository;

        public CharacteristicDescriptionHandler(ICudRepository cudRepository, ICharacteristicDescriptionRepository characteristicDescriptionRepository)
        {
            _cudRepository = cudRepository;
            _characteristicDescriptionRepository = characteristicDescriptionRepository;
        }

        public async Task<ICommandResult> Handle(CharacteristicDescriptionInsertCommand command)
        {
            //FFV
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(
                            false,
                            HttpStatusCode.BadRequest,
                            command.Notifications);

            CharacteristicDescription _entity = new CharacteristicDescription();
            _entity.CharacteristicId = command.CharacteristicId;
            _entity.CharacteristicKeyId = command.CharacteristicKeyId;

            var _result = await _cudRepository.Add(_entity);

            //retorna o resultado
            if (!_result)
                return new GenericCommandResult(false, HttpStatusCode.BadRequest, _result);

            return new GenericCommandResult(true, HttpStatusCode.Created, _result);
        }

        public async Task<ICommandResult> Handle(CharacteristicDescriptionDeleteCommand command)
        {
            //FFV
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(
                            false,
                            HttpStatusCode.BadRequest,
                            command.Notifications);

            var _verify = await _characteristicDescriptionRepository.FindById(command.Id);

            if (_verify == null)
                return new GenericCommandResult(false, HttpStatusCode.NotFound, "Não localizado na base");

            CharacteristicDescription _entity = new CharacteristicDescription();
            _entity.Id = command.Id;

            var _result = await _cudRepository.Delete(_entity);

            //retorna o resultado
            if (!_result)
                return new GenericCommandResult(false, HttpStatusCode.BadRequest, _result);

            return new GenericCommandResult(true, HttpStatusCode.OK, _result);
        }

        public async Task<ICommandResult> Handle(CharacteristicDescriptionUpdateCommand command)
        {
            //FFV
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(
                            false,
                            HttpStatusCode.BadRequest,
                            command.Notifications);

            var _verify = await _characteristicDescriptionRepository.FindById(command.Id);

            if (_verify == null)
                return new GenericCommandResult(false, HttpStatusCode.NotFound, "Não localizado na base");

            CharacteristicDescription _entity = new CharacteristicDescription();
            _entity.Id = command.Id;
            _entity.CharacteristicId = command.CharacteristicId;
            _entity.CharacteristicKeyId = command.CharacteristicKeyId;

            var _result = await _cudRepository.Delete(_entity);

            //retorna o resultado
            if (!_result)
                return new GenericCommandResult(false, HttpStatusCode.BadRequest, _result);

            return new GenericCommandResult(true, HttpStatusCode.OK, _result);
        }
    }
}
