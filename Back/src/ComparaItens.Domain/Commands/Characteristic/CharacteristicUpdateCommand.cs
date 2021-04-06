using Flunt.Notifications;
using Flunt.Validations;

namespace ComparaItens.Domain.Commands
{
    public class CharacteristicUpdateCommand : Notifiable, ICommand
    {

        public string Description { get; set; }

        public CharacteristicUpdateCommand(string description)
        {
            Description = description;
        }

        public void Validate()
        {
            AddNotifications(
                 new Contract()
                     .Requires()
                     .IsNotNullOrEmpty(Description, "Description", "Descrição não pode ser nulo")
             );
        }
    }
}
