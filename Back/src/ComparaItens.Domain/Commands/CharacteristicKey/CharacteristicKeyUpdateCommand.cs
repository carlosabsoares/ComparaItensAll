using Flunt.Notifications;
using Flunt.Validations;

namespace ComparaItens.Domain.Commands
{
    public class CharacteristicKeyUpdateCommand : Notifiable, ICommand
    {
        public int Id { get; set; }
        public int characteristicId { get; set; }
        public string Description { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .IsGreaterThan(Id, 0, "Id", "O id é obrigatório")
                    .IsGreaterThan(characteristicId,0, "characteristicId", "characteristicId não pode ser nulo")
                    .IsNotNullOrEmpty(Description, "Description", "Description não pode ser nulo")
            );
        }
    }
}