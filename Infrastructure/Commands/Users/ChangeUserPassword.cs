using Infrastructure.Commands;

namespace Infrastructure.Handlers.Users
{
    public class ChangeUserPassword : ICommand
    {
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }

    }
}