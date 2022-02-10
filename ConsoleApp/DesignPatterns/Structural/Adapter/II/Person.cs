﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Adapter.II
{
    public class Person : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
