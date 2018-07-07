using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.DTO;

namespace Infrastructure.Services
{
    public interface IDriverService
    {
        DriverDTO Get(Guid userId);
    }
}
