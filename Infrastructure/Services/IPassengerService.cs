using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.DTO;

namespace Infrastructure.Services
{
    public interface IPassengerService : IService
    {
        Task<PassengerDTO> GetAsync(Guid passengerId);
    }
}
