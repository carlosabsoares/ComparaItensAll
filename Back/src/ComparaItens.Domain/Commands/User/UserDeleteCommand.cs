using Flunt.Notifications;
using Flunt.Validations;

namespace ComparaItens.Domain.Commands
{
    public class UserDeleteCommand : Notifiable, ICommand
    {
        public int Id { get; set; }

        public UserDeleteCommand()
        {
        }

        public UserDeleteCommand(int id)
        {
            Id = id;
        }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .IsGreaterThan(Id, 0, "Id", "O id é obrigatório")
            );
        }
    }
}