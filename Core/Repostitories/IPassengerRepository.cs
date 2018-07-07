using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain;

namespace Core.Repostitories
{
    public interface IPassengerRepository
    {
        Passenger Get(Guid passengerId);
        IEnumerable<Passenger> GetAll();
        void Add(Passenger passenger);
        void Remove(Guid passengerId);
        void Update(Passenger passenger);
    }
}
