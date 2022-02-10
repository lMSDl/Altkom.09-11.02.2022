﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Decorator
{
    public class Notification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Wysłano wewnętrzą notyfikację: {message}");
        }

    }
}
