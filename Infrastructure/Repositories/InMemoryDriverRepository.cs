using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Domain;
using Core.Repostitories;

namespace Infrastructure.Repositories
{
    class InMemoryDriverRepository : IDriverRepository
    {
        private static ISet<Driver> _drivers = new HashSet<Driver>();

        public Driver Get(Guid userId)
            => _drivers.Single(x => x.UserId == userId);

        public IEnumerable<Driver> GetAll()
            => _drivers;

        public void Add(Driver driver)
        {
            _drivers.Add(driver);
        }

        public void Update(Driver driver)
        {
        }

        public void Remove(Guid userId)
        {
            var driver = Get(userId);
            _drivers.Remove(driver);
        }
    }
}
