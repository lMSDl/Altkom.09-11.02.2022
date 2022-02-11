using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class StringLogger<TService> : Logger<string, TService> where TService : IDisposable
    {
        protected override string ConvertMessage(string message)
        {
            return message;
        }
    }
}
