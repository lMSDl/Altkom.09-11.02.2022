using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Creational
{
    public class VehicleBuilder
    {
        private Vehicle _vehicle = new Vehicle();

        public VehicleBuilder SetWeels(int wheels)
        {
            _vehicle.Wheels = wheels;
            return this;
        }

        public VehicleBuilder SetDoors(int doors)
        {
            _vehicle.Doors = doors;
            return this;
        }

        public VehicleBuilder SetEnginePower(int power)
        {
            _vehicle.EnginePower = power;
            return this;
        }

        public VehicleBuilder SetTrunkCapacity(int capacity)
        {
            _vehicle.TrunkCapacity = capacity;
            return this;
        }

        public VehicleBuilder SetSeats(int seats)
        {
            _vehicle.Seats = seats;
            return this;
        }

        public Vehicle Build()
        {
            return _vehicle;
        }
    }
}
