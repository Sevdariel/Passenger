using System.Threading.Tasks;
using Infrastructure.Commands;
using Infrastructure.Handlers.Users;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Rest.Azure;

namespace Api.Controllers
{
    public class AccountController : ApiControllerBase
    {
        public AccountController(ICommandDispatcher commandDispatcher) 
            : base(commandDispatcher)
        {
        }

        [HttpPut]
        [Route("password")]
        public async Task<IActionResult> Put([FromBody]ChangeUserPassword command)
        {
            await CommandDispatcher.DispatchAsync(command);

            return NoContent();
        }
    }
}