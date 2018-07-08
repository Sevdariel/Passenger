using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain;

namespace Core.Repostitories
{
    public interface IPassengerRepository
    {
        Task<Passenger> GetAsync(Guid passengerId);
        Task<IEnumerable<Passenger>> GetAllAsync();
        Task AddAsync(Passenger passenger);
        Task RemoveAsync(Guid passengerId);
        Task UpdateAsync(Passenger passenger);
    }
}
