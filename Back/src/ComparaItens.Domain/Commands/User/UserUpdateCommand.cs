using Flunt.Notifications;
using Flunt.Validations;

namespace ComparaItens.Domain.Commands
{
    public class UserUpdateCommand : Notifiable, ICommand
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .IsGreaterThan(Id, 0, "Id", "O id é obrigatório")
                    .IsNotNullOrEmpty(Password, "Password", "Password não pode ser nulo")
                    .IsNotNullOrEmpty(Role.ToString(), "Role", "Role não pode ser nulo")
                    .IsNotNullOrEmpty(Name, "Name", "Name não pode ser nulo")
                    .IsNotNullOrEmpty(Email, "Email", "Email não pode ser nulo")
            );
        }
    }
}