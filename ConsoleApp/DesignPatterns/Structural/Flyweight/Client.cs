using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Flyweight
{
    public class Client
    {
        public static void Execute()
        {
            var cars = new List<Car>
            {
                new Car { Color = "Red", Manufacturer = "BMW", Model = "X3", Number = "WDZ 92023", Owner = "Piotr Piotrowski" },
                new Car { Color = "Blue", Manufacturer = "Skoda", Model = "Superb", Number = "WW 92122", Owner = "Ewa Ewowska" },
                new Car { Color = "Red", Manufacturer = "Toyota", Model = "Rav4", Number = "ZAS 99212", Owner = "Piotr Ewowski" },
                new Car { Color = "White", Manufacturer = "Audi", Model = "A4", Number = "PPO 12332", Owner = "Ewa Piotrowska" },
                new Car { Color = "White", Manufacturer = "Audi", Model = "A4", Number = "PPO 12212", Owner = "Adam Adamski" },
                new Car { Color = "White", Manufacturer = "Audi", Model = "A4", Number = "PPO 12662", Owner = "Tomasz Tomaszewski" },
            };

            var factory = new FlyweightFactory(new CarFlyweight { Color = "Blue", Manufacturer = "Skoda", Model = "Superb" },
                new CarFlyweight { Color = "Red", Manufacturer = "Toyota", Model = "Rav4" });

            factory.ListFlyweights();

            foreach (var item in cars)
            {
                item.CarFlyweight = factory.Cache(item.CarFlyweight);
            }

            factory.ListFlyweights();

            for (int i = 0; i < 10; i++)
            {
                var car = new Car { Color = "White", Manufacturer = "Audi", Model = "A4", Number = i.ToString(), Owner = i.ToString() };
               car.CarFlyweight = factory.Cache(car.CarFlyweight);
                cars.Add(car);
            }

            factory.ListFlyweights();

            //cars.Last().Color = "Blue";
            var lastCar = cars.Last();
            lastCar.CarFlyweight = factory.Cache(new CarFlyweight { Manufacturer = lastCar.Manufacturer, Model = lastCar.Model, Color = "Blue" });
        }
    }
}
