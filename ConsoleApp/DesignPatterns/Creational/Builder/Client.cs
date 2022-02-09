using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Creational.Builder
{
    public class Client
    {
        public static void Execute()
        {
            //var vehicle = new Vehicle(4, 5, 4, 500, 100);
            var vehicleBuilder = new VehicleBuilder();
            vehicleBuilder.SetWeels(4);
            vehicleBuilder.SetSeats(5);
            vehicleBuilder.SetDoors(4);
            vehicleBuilder.SetTrunkCapacity(500);
            vehicleBuilder.SetEnginePower(100);

            //var vehicle = vehicleBuilder.Build();



            vehicleBuilder = new VehicleBuilder()
            .SetWeels(4)
            .SetSeats(5)
            .SetDoors(4)
            .SetTrunkCapacity(500)
            .SetEnginePower(100);

            var vehicle = vehicleBuilder.Build();
            Console.WriteLine(vehicle);

            vehicle = vehicleBuilder.SetEnginePower(150).Build();
            Console.WriteLine(vehicle);
        }
    }
}
