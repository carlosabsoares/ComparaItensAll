using Flunt.Notifications;
using Flunt.Validations;

namespace ComparaItens.Domain.Commands
{
    public class CharacteristicInsertCommand : Notifiable, ICommand
    {
        public string Description { get; set; }
        public int CategoryId { get; set; }

        public CharacteristicInsertCommand(string description, int categoryId)
        {
            Description = description;
            CategoryId = categoryId;
        }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .IsGreaterThan(CategoryId, 0, "CategoryId", "O id da categoria é obrigatório")
                    .IsNotNullOrEmpty(Description, "Description", "Descrição não pode ser nulo")
            );
        }
    }
}