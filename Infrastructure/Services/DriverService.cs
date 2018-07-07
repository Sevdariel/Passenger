using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Core.Domain;
using Core.Repostitories;
using Infrastructure.DTO;

namespace Infrastructure.Services
{
    public class DriverService : IDriverService
    {
        private readonly IDriverRepository _driverRepository;
        private readonly IMapper _mapper;

        public DriverService(IDriverRepository driverRepository, IMapper mapper)
        {
            _driverRepository = driverRepository;
            _mapper = mapper;
        }

        public DriverDTO Get(Guid userId)
        {
            var driver = _driverRepository.Get(userId);

            return _mapper.Map<Driver, DriverDTO>(driver);
        }
    }
}
