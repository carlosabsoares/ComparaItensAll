using Flunt.Notifications;
using Flunt.Validations;

namespace ComparaItens.Domain.Commands
{
    public class CategoryInsertCommand : Notifiable, ICommand
    {
        public string Description { get; set; }

        public CategoryInsertCommand()
        {
        }

        public CategoryInsertCommand(int id, string desciption)
        {
            Description = desciption;
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