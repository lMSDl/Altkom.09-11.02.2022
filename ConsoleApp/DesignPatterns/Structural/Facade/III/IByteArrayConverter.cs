﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Facade.III
{
    public interface IByteArrayConverter
    {
        string ToByteArray<T>(T item);
    }
}
