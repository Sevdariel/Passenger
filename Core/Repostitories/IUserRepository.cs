using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain;

namespace Core.Repostitories
{
    public interface IUserRepository
    {
        User Get(Guid id);
        User Get(string email);
        void Add(User user);
        void Remove(Guid id);
        void Update(User user);
        IEnumerable<User> GetAll();
    }
}
