using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Core.Domain;
using Core.Repostitories;

namespace Infrastructure.Repositories
{
    public class InMemoryPassengerRepository : IPassengerRepository
    {
        private static ISet<Passenger> _passengers = new HashSet<Passenger>();

        public Passenger Get(Guid passengerId)
            => _passengers.Single(x => x.UserId == passengerId);

        public IEnumerable<Passenger> GetAll()
            => _passengers;

        public void Add(Passenger passenger)
        {
            _passengers.Add(passenger);
        }

        public void Remove(Guid passengerId)
        {
            var passenger = Get(passengerId);
            _passengers.Remove(passenger);
        }

        public void Update(Passenger passenger)
        {
        }
    }
}
