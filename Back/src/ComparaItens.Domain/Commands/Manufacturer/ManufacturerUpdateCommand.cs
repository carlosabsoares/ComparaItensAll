using Flunt.Notifications;
using Flunt.Validations;

namespace ComparaItens.Domain.Commands
{
    public class ManufacturerUpdateCommand : Notifiable, ICommand
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public ManufacturerUpdateCommand()
        {
        }

        public ManufacturerUpdateCommand(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .IsGreaterThan(Id, 0, "Id", "O id é obrigatório")
                    .IsNotNullOrEmpty(Description, "Description", "Descrição não pode ser nulo")
            );
        }
    }
}