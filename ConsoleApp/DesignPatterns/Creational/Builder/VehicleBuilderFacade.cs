using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Creational.Builder
{
    public class VehicleBuilderFacade : VehicleBuilderBase
    {
        public VehicleBuilderFacade()
        {
            Components = new VehicleBuilder(vehicle);
            Info = new VehicleInfoBuilder(vehicle);
        }

        public VehicleBuilderFacade(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleBuilder Components { get; } 
        public VehicleInfoBuilder Info { get; }
    }
}
