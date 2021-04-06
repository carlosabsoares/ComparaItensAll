using Flunt.Notifications;
using Flunt.Validations;

namespace ComparaItens.Domain.Commands
{
    public class CharacteristicDeleteCommand : Notifiable, ICommand
    {

        public int Id { get; set; }
        public string Description { get; set; }

        public CharacteristicDeleteCommand(int id)
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
