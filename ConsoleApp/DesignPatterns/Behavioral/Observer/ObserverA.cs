﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Observer
{
    public class ObserverA : Observer<int>
    {
        public override void OnNext(int value)
        {
            if (value > 7 || value < 3)
            {
                Console.WriteLine($"{nameof(ObserverA)}: thinking...");
                Thread.Sleep(value * 1000);
                Console.WriteLine($"{nameof(ObserverA)}: reacts");
            
            }

        }
    }
}
