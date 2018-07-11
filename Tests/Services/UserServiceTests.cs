using System.Threading.Tasks;
using AutoMapper;
using Core.Domain;
using Core.Repostitories;
using Infrastructure.Services;
using Moq;
using NUnit.Framework;

namespace Tests.Services
{
    [TestFixture]
    public class UserServiceTests
    {
        [Test]
        public async Task RegisterAsync_ShouldInvokeAddAsyncOnRepository()
        {
            var userRepositoryMock = new Mock<IUserRepository>();
            var mapperMock = new Mock<IMapper>();

            var userService = new UserService(userRepositoryMock.Object, mapperMock.Object);
            await userService.RegisterAsync("user@email.com", "user", "secret", "user");

            userRepositoryMock.Verify(x => x.AddAsync(It.IsAny<User>()), Times.Once);
        }
    }
}