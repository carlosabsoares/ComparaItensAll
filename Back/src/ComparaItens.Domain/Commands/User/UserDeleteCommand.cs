using Flunt.Notifications;
using Flunt.Validations;

namespace ComparaItens.Domain.Commands
{
    public class UserDeleteCommand : Notifiable, ICommand
    {
        public string Id { get; set; }

        public UserDeleteCommand()
        {
        }

        public UserDeleteCommand(string id)
        {
            Id = id;
        }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .IsNotNullOrEmpty(Id, "Id", "Id não pode ser nulo")
            );
        }
    }
}