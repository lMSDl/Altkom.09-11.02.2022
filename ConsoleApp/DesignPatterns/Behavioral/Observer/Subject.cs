using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Observer
{
    public class Subject : IObservable<int>, IDisposable
    {
        private List<IObserver<int>> _observers = new List<IObserver<int>>();

        public void Dispose()
        {
            _observers.ToList().ForEach(x => x.OnCompleted());
        }

        public IDisposable Subscribe(IObserver<int> observer)
        {
            _observers.Add(observer);
            return new Unsubscriber(() => _observers.Remove(observer));
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("Start calculations...");
            Thread.Sleep(2000);

            Index = new Random().Next(-1, 10);
            Console.WriteLine("Finished calculations...");

            Console.WriteLine(Index);
            Notify();

        }


        public int Index { get; private set; }

        public void Notify()
        {
            if (Index < 0)
                _observers.ToList().ForEach(x => x.OnError(new IndexOutOfRangeException()));
            else
            {
                _observers.ToList().ForEach(x => Task.Run(() => x.OnNext(Index)));
            }
        }
    }
}
