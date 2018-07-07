using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain
{
    public class DailyRoute
    {
        public Guid Id { get; protected set; }
        public Route Route { get; protected set; }
        public IEnumerable<PassengerNode> PassengerNode { get; protected set; }
    }
}
