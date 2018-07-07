using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain;

namespace Core.Repostitories
{
    public interface IDriverRepository
    {
        Driver Get(Guid userId);
        IEnumerable<Driver> GetAll();
        void Add(Driver driver);
        void Update(Driver driver);
        void Remove(Guid userId);
    }
}
