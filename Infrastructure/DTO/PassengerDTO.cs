using System;
using Core.Domain;

namespace Infrastructure.DTO
{
    public class PassengerDTO
    {
        public Guid UserId { get; protected set; }
        public Node Address { get; protected set; }
    }
}