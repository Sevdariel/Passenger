using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Core.Domain;
using Infrastructure.DTO;

namespace Infrastructure.Mapper
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>();
                cfg.CreateMap<Driver, DriverDTO>();
            }).CreateMapper();
    }
}
