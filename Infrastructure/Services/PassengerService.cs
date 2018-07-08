using System;
using System.Threading.Tasks;
using AutoMapper;
using Core.Domain;
using Core.Repostitories;
using Infrastructure.DTO;

namespace Infrastructure.Services
{
    public class PassengerService
    {
        private readonly IPassengerRepository _passengerRepository;
        private readonly IMapper _mapper;

        public PassengerService(IPassengerRepository passengerRepository,
            IMapper mapper)
        {
            _passengerRepository = passengerRepository;
            _mapper = mapper;
        }

        public async Task<PassengerDTO> GetAsync(Guid userId)
        {
            var passenger = await _passengerRepository.GetAsync(userId);

            return _mapper.Map<Passenger, PassengerDTO>(passenger);
        }
    }
}