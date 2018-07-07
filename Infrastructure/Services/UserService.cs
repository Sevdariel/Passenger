using System;
using System.Collections.Generic;
using System.Text;
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

        public UserDTO Get(string email)
        {
            var user = _userRepository.Get(email);

            return _mapper.Map<User, UserDTO>(user);
        }

        public void Register(string email, string userName, string password)
        {
            var user = _userRepository.Get(email);

            if (user != null)
                throw new Exception($"User with email: '{email}' already exists.");

            var salt = Guid.NewGuid().ToString("N");
            user = new User(email, password, salt, userName);
            _userRepository.Add(user);
        }
    }
}
