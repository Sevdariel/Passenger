using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.DTO;

namespace Infrastructure.Services
{
    public interface IUserService
    {
        UserDTO Get(string email);
        void Register(string email, string userName, string password);
    }
}
