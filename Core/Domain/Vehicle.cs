using System;

namespace Core.Domain
{
    public class Vehicle
    {
        public string Name { get; protected set; }
        public int Seats { get; protected set; }
        public string Brand { get; protected set; }

        public static Vehicle Create(string name, int seats, string brand)
            => new Vehicle(name, seats ,brand);

        public Vehicle(string name, int seats, string brand)
        {
            SetName(name);
            SetSeats(seats);
            SetBrand(brand);
        }

        private void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Please provide proper car name");
            if (Name == name)
                return;

            Name = name;
        }

        private void SetSeats(int seats)
        {
            if (seats < 1 || seats > 9)
                throw new Exception("Number of seats cant be less than 1 and greater than 9");
            if (Seats == seats)
                return;

            Seats = seats;
        }

        private void SetBrand(string brand)
        {
            if (string.IsNullOrWhiteSpace(brand))
                throw new Exception("Please provide proper car name");
            if (Brand == brand)
                return;

            Brand = brand;
        }
    }
}