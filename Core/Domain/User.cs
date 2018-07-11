using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Core.Domain
{
    public class User
    {
        private static readonly Regex NameRegex = new Regex("^(?![_.-])(?!.*[_.-]{2})[a-zA-Z0-9._.-]+(?<![_.-])$");
        public Guid Id { get; protected set; }
        public string Email { get; protected set; }
        public string Username { get; protected set; }
        public string Password { get; protected set; }
        public string FullName { get; protected set; }
        public string Role {get; protected set;}
        public string Salt { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }

        protected User()
        {
        }

        public User(string email, string password, string salt, string username, string role)
        {
            Id = Guid.NewGuid();
            SetEmail(email);
            SetPassword(password);
            Salt = salt;
            Role = role;
            SetUsername(username);
            CreatedAt = DateTime.UtcNow;
        }

        private void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new Exception("Email cant be empty");

            Email = email.ToLowerInvariant();
            UpdatedAt = DateTime.UtcNow;
        }

        private void SetPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new Exception("Password cant be empty");
            if (password.Length < 4)
                throw new Exception("Password has to be longer than 4 signs");
            else if (password.Length > 25)
                throw new Exception("Password cant be longer than 25 signs");

            Password = password;
            UpdatedAt = DateTime.UtcNow;
        }

        private void SetUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new Exception("Username cant be empty");
            if (!NameRegex.IsMatch(username))
                throw new Exception("Username contains invalid signs");
            if (username.Length > 50)
                throw new Exception("Username cant be longer than 50 signs");
            else if (username.Length < 3)
                throw new Exception("Username cant be shorter than 3");

            Username = username.ToLowerInvariant();
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetRole(string role)
        {
            Role = role;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
