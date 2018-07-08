using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.DTO;

namespace Infrastructure.Services
{
    public interface IUserService
    {
        Task<UserDTO> GetAsync(string email);
        Task RegisterAsync(string email, string userName, string password);
    }
}
