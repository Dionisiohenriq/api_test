using Flunt.Notifications;
using Flunt.Validations;


namespace api_test.Domain.Commands.Inputs
{
    public class GenerateVirtualCardCommand : Notifiable<Notification>
    {
        public string Email { get; set; }
        public void Validate()
        {
            AddNotifications(new Contract<Notification>().IsEmail(Email, "Email", "Invalid Email"));
        }
    }
}
