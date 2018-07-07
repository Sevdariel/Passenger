using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain
{
    public class Driver
    {
        public Guid UserId { get; protected set; }
        public Vehicle Vehicle { get; protected set; }
        public IEnumerable<Route> Routes { get; protected set; }
        public IEnumerable<DailyRoute> DailyRoutes { get; protected set; }

        protected Driver()
        {
        }

        public Driver(Guid id, Guid userid)
        {
            UserId = userid;
        }
    }
}
