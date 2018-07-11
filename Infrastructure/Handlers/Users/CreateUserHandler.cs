using System.Threading.Tasks;
using Infrastructure.Commands;
using Infrastructure.Commands.Users;
using Infrastructure.Services;

namespace Infrastructure.Handlers.Users
{
    public class CreateUserHandler : ICommandHandler<CreateUser>
    {
        private readonly IUserService _userService;

        public CreateUserHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task HandleAsync(CreateUser command)
        {
            await _userService.RegisterAsync(command.Email, command.Username, command.Password, command.Role);
        }
    }
}