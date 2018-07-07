using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain;

namespace Infrastructure.DTO
{
    public class DriverDTO
    {
        public Guid UserId { get; set; }
        public Vehicle Vehicle { get; set; }
        public IEnumerable<Route> Routes { get; set; }
        public IEnumerable<DailyRoute> DailyRoutes { get; set; }
    }
}
