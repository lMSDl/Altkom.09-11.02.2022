using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Creational.Builder
{
    public abstract class VehicleBuilderBase
    {
        protected Vehicle vehicle = new Vehicle();

        protected VehicleBuilderBase()
        {
        }

        protected VehicleBuilderBase(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public Vehicle Build()
        {
            return (Vehicle)vehicle.Clone();
        }
    }
}
