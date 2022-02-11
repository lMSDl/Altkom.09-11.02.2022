using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Observer
{
    public abstract class Observer<T> : IObserver<T>
    {
        public IDisposable Subscription { get; set; }

        public void Subscribe(IObservable<T> stream)
        {
            Subscription = stream.Subscribe(this);
        }

        public void OnCompleted()
        {
            Console.WriteLine($"{GetType().Name}: Transmission completed");
            Subscription.Dispose();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"{GetType().Name}: {error.Message}");
        }

        public abstract void OnNext(T value);
    }
}
