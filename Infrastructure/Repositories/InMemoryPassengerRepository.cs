using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Core.Domain;
using Core.Repostitories;

namespace Infrastructure.Repositories
{
    public class InMemoryPassengerRepository : IPassengerRepository
    {
        private static ISet<Passenger> _passengers = new HashSet<Passenger>();

        public async Task<Passenger> GetAsync(Guid passengerId)
            => await Task.FromResult(_passengers.Single(x => x.UserId == passengerId));

        public async Task<IEnumerable<Passenger>> GetAllAsync()
            => await Task.FromResult(_passengers);

        public async Task AddAsync(Passenger passenger)
        {
            _passengers.Add(passenger);
            await Task.CompletedTask;
        }

        public async Task RemoveAsync(Guid passengerId)
        {
            var passenger = await GetAsync(passengerId);
            _passengers.Remove(passenger);
            await Task.CompletedTask;
        }

        public async Task UpdateAsync(Passenger passenger)
        {
            await Task.CompletedTask;
        }
    }
}
