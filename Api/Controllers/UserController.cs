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
        public UserDTO Get(string email)
            => _userService.Get(email);

        [HttpPost]
        public void Post([FromBody]CreateUser request)
        {
            _userService.Register(request.Email, request.Username, request.Password);
        }
    }
}
