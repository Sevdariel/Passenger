using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Api;
using Infrastructure.Handlers.Users;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Tests.EndToEnd.Controllers
{
    public class AccountControllerTests : ControllerTestsBase
    {
        [Test]
        public async Task GivenValidCurrentAndNewPasswordItShouldBeChanged()
        {
            var command = new ChangeUserPassword
            {
                CurrentPassword = "secret",
                NewPassword = "secret2"
            };

            var payload = GetPayload(command);
            var response = await Client.PutAsync("account/password", payload);
            Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);
        }

        private static StringContent GetPayload(object data)
        {
            var json = JsonConvert.SerializeObject(data);

            return new StringContent(json, Encoding.UTF8, "application/json");
        }
    }
}