using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Creational.AbstractFactory
{
    public static class Client
    {
        public static void Execute()
        {
            Order order;
            order = new Order(new HondaFactory(), nameof(ISedan), "compact");
        }
    }
}

