using Flunt.Notifications;
using Flunt.Validations;

namespace ComparaItens.Domain.Commands
{
    public class CharacteristicKeyInsertCommand : Notifiable, ICommand
    {
        
        public int CharacteristicId { get; set; }
        public string Description { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .IsGreaterThan(CharacteristicId,0, "Key", "Key não pode ser nulo")
                    .IsNotNullOrEmpty(Description, "Description", "Description não pode ser nulo")
            );
        }
    }
}