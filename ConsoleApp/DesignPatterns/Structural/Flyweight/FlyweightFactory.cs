using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Flyweight
{
    public class FlyweightFactory
    {
        private readonly Dictionary<string, CarFlyweight> _flyweights;

        public FlyweightFactory(params CarFlyweight[] values)
        {
            _flyweights = values.ToDictionary(x => GetKey(x));
        }

        public string GetKey(CarFlyweight carFlyweight)
        {
            var values = carFlyweight.GetType().GetProperties().OrderBy(x => x.Name)
                .Where(x => x.PropertyType == typeof(string))
                .Select(x => x.GetValue(carFlyweight)).ToList();

            return string.Join("_", values);
        }

        public CarFlyweight Cache(CarFlyweight carFlyweight)
        {
            var key = GetKey(carFlyweight);

            if (_flyweights.TryGetValue(key, out var result))
            {
                Console.WriteLine($"Klucz {key} istnieje");
                return result;
            }
            
            Console.WriteLine($"Nowy klucz {key}");
            _flyweights[key] = carFlyweight;
            return carFlyweight;
        }

        public void ListFlyweights()
        {
            Console.WriteLine($"\nIlość składowanych płatków: {_flyweights.Count}");
            foreach (var item in _flyweights)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
