using System.Threading.Tasks;
using Infrastructure.Commands;
using Infrastructure.Handlers.Users;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Rest.Azure;

namespace Api.Controllers
{
    public class DriverController : ApiControllerBase
    {
        public DriverController(ICommandDispatcher commandDispatcher) 
            : base(commandDispatcher)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]ChangeUserPassword command)
        {
            await CommandDispatcher.DispatchAsync(command);

            return NoContent();
        }
    }
}