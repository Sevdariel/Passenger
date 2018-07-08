using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Commands.Users;
using Infrastructure.DTO;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{email}")]
        public async Task<UserDTO> Get(string email)
            => await _userService.GetAsync(email);

        [HttpPost]
        public async Task Post([FromBody]CreateUser request)
            => await _userService.RegisterAsync(request.Email, request.Username, request.Password);
    }
}
