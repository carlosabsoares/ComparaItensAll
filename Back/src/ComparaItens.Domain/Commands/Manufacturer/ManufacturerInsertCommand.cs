using Flunt.Notifications;
using Flunt.Validations;

namespace ComparaItens.Domain.Commands
{
    public class ManufacturerInsertCommand : Notifiable, ICommand
    {
        public string Description { get; set; }

        public ManufacturerInsertCommand()
        {
        }

        public ManufacturerInsertCommand(string desciption)
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