using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Observer
{
    public class Client
    {
        public static void Execute()
        {
            using var subject = new Subject();

            var observerA = new ObserverA();
            var observerB = new ObserverB();

            observerA.Subscribe(subject);
            observerB.Subscribe(subject);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            observerB.Subscription.Dispose();
            subject.SomeBusinessLogic();

            observerB.Subscribe(subject);
            subject.SomeBusinessLogic();
        }
        }
}
