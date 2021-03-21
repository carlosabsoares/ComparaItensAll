using Flunt.Notifications;
using Flunt.Validations;

namespace ComparaItens.Domain.Commands
{
    public class UserValidateAccessCommand : Notifiable, ICommand
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .IsNotNullOrEmpty(Login, "Login", "Login não pode ser nulo")
                    .IsNotNullOrEmpty(Password, "Password", "Password não pode ser nulo")
            );
        }
    }
}