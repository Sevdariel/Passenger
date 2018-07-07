using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DTO
{
    public class UserDTO
    {
        public Guid Id { get;  set; }
        public string Email { get;  set; }
        public string UserName { get;  set; }
        public string FullName { get;  set; }
    }
}
