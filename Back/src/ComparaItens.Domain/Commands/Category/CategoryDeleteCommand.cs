using Flunt.Notifications;
using Flunt.Validations;

namespace ComparaItens.Domain.Commands
{
    public class CategoryDeleteCommand : Notifiable, ICommand
    {
        public int Id { get; set; }

        public CategoryDeleteCommand()
        {
        }

        public CategoryDeleteCommand(int id)
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