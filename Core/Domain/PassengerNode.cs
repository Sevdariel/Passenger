using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain
{
    public class PassengerNode
    {
        public Node Node { get; protected set; }
        public Passenger Passenger { get; protected set; }
    }
}
