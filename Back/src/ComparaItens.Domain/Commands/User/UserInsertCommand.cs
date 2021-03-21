using Flunt.Notifications;
using Flunt.Validations;

namespace ComparaItens.Domain.Commands
{
    public class UserInsertCommand : Notifiable, ICommand
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .IsNotNullOrEmpty(Login, "Login", "Login não pode ser nulo")
                    .IsNotNullOrEmpty(Password, "Password", "Password não pode ser nulo")
                    .IsNotNullOrEmpty(Role.ToString(), "Role", "Role não pode ser nulo")
                    .IsNotNullOrEmpty(Name, "Name", "Name não pode ser nulo")
                    .IsNotNullOrEmpty(Email, "Email", "Email não pode ser nulo")
            );
        }
    }
}