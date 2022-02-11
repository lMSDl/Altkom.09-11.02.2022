using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Observer
{
    public class Unsubscriber : IDisposable
    {
        private Action action;

        public Unsubscriber(Action action)
        {
            this.action = action;
        }

        public void Dispose()
        {
            action();
        }
    }
}
