using Flunt.Notifications;
using Flunt.Validations;

namespace ComparaItens.Domain.Commands
{
    public class CharacteristicUpdateCommand : Notifiable, ICommand
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }

        public CharacteristicUpdateCommand()
        {
        }

        public CharacteristicUpdateCommand(int id, string description, int categoryId)
        {
            Id = id;
            Description = description;
            CategoryId = categoryId;
        }

        public void Validate()
        {
            AddNotifications(
                 new Contract()
                     .Requires()
                     .IsGreaterThan(Id, 0, "Id", "O id é obrigatório")
                     .IsNotNullOrEmpty(Description, "Description", "Descrição não pode ser nulo")
                     .IsGreaterThan(CategoryId, 0, "CategoryId", "O id da categoria é obrigatório")
             );
        }
    }
}