using System.Threading.Tasks;
using Infrastructure.Commands;
using Infrastructure.Commands.Drivers;
using Infrastructure.Services;

namespace Infrastructure.Handlers.Drivers
{
    public class CreateDriverHandler : ICommandHandler<CreateDriver>
    {
        private readonly IDriverService _driverService;
        public CreateDriverHandler(IDriverService driverService)
        {
            _driverService = driverService;
        }
        public async Task HandleAsync(CreateDriver command)
        {
            await Task.CompletedTask;
        }
    }
}