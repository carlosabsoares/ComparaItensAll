using Flunt.Notifications;
using Flunt.Validations;

namespace ComparaItens.Domain.Commands
{
    public class CharacteristicDescriptionUpdateCommand : Notifiable, ICommand
    {
        public int Id { get; set; }
        public int CharacteristicId { get; set; }
        public int CharacteristicKeyId { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .IsGreaterThan(Id, 0, "CharacteristicId", "O CharacteristicId é obrigatório")
                    .IsGreaterThan(CharacteristicId, 0, "CharacteristicId", "O CharacteristicId é obrigatório")
                    .IsGreaterThan(CharacteristicKeyId, 0, "CharacteristicKeyId", "O CharacteristicKeyId é obrigatório")
            );
        }
    }
}