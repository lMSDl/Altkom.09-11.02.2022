using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    public abstract class BaseHandler<T>
    {
        protected T NextHandler { get; }

        protected BaseHandler(T handler)
        {
            NextHandler = handler;
        }
    }
}
