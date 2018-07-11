using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core.Domain;
using Core.Repostitories;
using Infrastructure.DTO;

namespace Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDTO> GetAsync(string email)
        {
            var user = await _userRepository.GetAsync(email);

            return _mapper.Map<User, UserDTO>(user);
        }

        public async Task RegisterAsync(string email, string userName, string password, string role)
        {
            var user = await _userRepository.GetAsync(email);

            if (user != null)
                throw new Exception($"User with email: '{email}' already exists.");

            var salt = Guid.NewGuid().ToString("N");
            user = new User(email, password, salt, userName, role);
            await _userRepository.AddAsync(user);
        }
    }
}
