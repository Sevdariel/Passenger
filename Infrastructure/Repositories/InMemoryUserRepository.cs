using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Domain;
using Core.Repostitories;

namespace Infrastructure.Repositories
{
    public class InMemoryUserRepository : IUserRepository
    {
        private static ISet<User> _users = new HashSet<User>()
        {
            new User("user1@email.com", "secret", "salt", "user1"),
            new User("user2@email.com", "secret", "salt", "user2"),
            new User("user3@email.com", "secret", "salt", "user3")
        };

        public User Get(Guid id) 
            => _users.SingleOrDefault(x => x.Id == id);

        public User Get(string email)
            => _users.SingleOrDefault(x => x.Email == email.ToLowerInvariant());

        public void Add(User user)
        {
            _users.Add(user);
        }

        public void Remove(Guid id)
        {
            var user = Get(id);
            _users.Remove(user);
        }

        public void Update(User user)
        {
        }

        public IEnumerable<User> GetAll()
            => _users;
    }
}
