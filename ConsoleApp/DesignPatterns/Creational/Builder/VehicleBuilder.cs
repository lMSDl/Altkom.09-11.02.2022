using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Creational.Builder
{
    public class VehicleBuilder : VehicleBuilderFacade
    {


        public VehicleBuilder(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleBuilder()
        {
        }

        public VehicleBuilder SetWeels(int wheels)
        {
            vehicle.Wheels = wheels;
            return this;
        }

        public VehicleBuilder SetDoors(int doors)
        {
            vehicle.Doors = doors;
            return this;
        }

        public VehicleBuilder SetEnginePower(int power)
        {
            vehicle.EnginePower = power;
            return this;
        }

        public VehicleBuilder SetTrunkCapacity(int capacity)
        {
            vehicle.TrunkCapacity = capacity;
            return this;
        }

        public VehicleBuilder SetSeats(int seats)
        {
            vehicle.Seats = seats;
            return this;
        }

        public Vehicle Build()
        {
            return (Vehicle)vehicle.Clone();
        }
    }
}
