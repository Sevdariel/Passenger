using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Api;
using Infrastructure.Commands.Users;
using Infrastructure.DTO;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.WebSockets.Internal;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Tests.EndToEnd.Controllers
{
    public class UsersControllerTests
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public UsersControllerTests()
        {
            _server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [Test]
        public async Task GivenValidEmailUserShouldExist()
        {
            var email = "user1@email.com";
            var user = await GetUserAsync(email);

            Assert.AreEqual(user.Email, email);
        }

        [Test]
        public async Task GivenValidEmailUserShouldNotExist()
        {
            var email = "user1000@email.com";
            var response = await _client.GetAsync($"users/{email}");

            Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Test]
        public async Task GivenUniqueEmailUserShouldBeCreated()
        {
            var request = new CreateUser
            {
                Email = "test@email.com",
                Username = "test",
                Password = "secret"
            };
            var payload = GetPayload(request);
            var response = await _client.PostAsync("users", payload);

            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
            Assert.AreEqual(response.Headers.Location.ToString(), $"users/{request.Email}");

            var user = await GetUserAsync(request.Email);
            Assert.AreEqual(user.Email, request.Email);
        }

        private async Task<UserDTO> GetUserAsync(string email)
        {
            var response = await _client.GetAsync($"users/{email}");
            var responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<UserDTO>(responseString);
        }

        private static StringContent GetPayload(object data)
        {
            var json = JsonConvert.SerializeObject(data);

            return new StringContent(json, Encoding.UTF8, "application/json");
        }
    }
}