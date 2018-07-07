using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain
{
    public class Passenger
    {
        public Guid UserId { get; protected set; }
        public Node Address { get; protected set; }
    }
}
