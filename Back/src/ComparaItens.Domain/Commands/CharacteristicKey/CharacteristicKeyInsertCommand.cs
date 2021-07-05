using Flunt.Notifications;
using Flunt.Validations;

namespace ComparaItens.Domain.Commands
{
    public class CharacteristicKeyInsertCommand : Notifiable, ICommand
    {
        //public string Key { get; set; }
        public int characteristicId { get; set; }
        public string Description { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .IsGreaterThan(characteristicId,0, "Key", "Key não pode ser nulo")
                    .IsNotNullOrEmpty(Description, "Description", "Description não pode ser nulo")
            );
        }
    }
}