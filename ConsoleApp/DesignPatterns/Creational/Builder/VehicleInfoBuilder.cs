using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Creational.Builder
{
    public class VehicleInfoBuilder : VehicleBuilderFacade
    {
        public VehicleInfoBuilder(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleInfoBuilder SetManufacturer(string value)
        {
            vehicle.Manufacturer = value;
            return this;
        }
        public VehicleInfoBuilder SetYearOfProduction(DateTime value)
        {
            vehicle.YearOfProduction = value;
            return this;
        }
        public VehicleInfoBuilder SetModelName(string value)
        {
            vehicle.ModelName = value;
            return this;
        }

    }
}
