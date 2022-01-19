using System;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Observer Pattern Demo***");
            IObserver myObserver1 = new ObserverType1("Roy");
            IObserver myObserver2 = new ObserverType1("Kevin");
            IObserver myObserver3 = new ObserverType2("Bose");
            IObserver myObserver4 = new ObserverType2("Jaklin");

            Console.WriteLine("Working with first celebrity now.");
            ICelebrity celebrity1 = new Celebrity("Celebrity-1");

            celebrity1.Register(myObserver1);
            celebrity1.Register(myObserver2);
            celebrity1.Register(myObserver3);
            Console.WriteLine("Celebrity-1 is setting Flag = 5");
            celebrity1.Flag = 5;

            Console.WriteLine("Celebrity-1 is removing Kevin from the observer list now.");
            celebrity1.Unregister(myObserver2);
            Console.WriteLine("Celebrity-1 is setting flag = 50");
            celebrity1.Flag = 50;

            celebrity1.Register(myObserver2);
            Console.WriteLine("Working with another celebrity now.");
            ICelebrity celebrity2 = new Celebrity("Celebrity-2");
            celebrity2.Register(myObserver1);
            celebrity2.Register(myObserver4);
            Console.WriteLine("Celebrity-2 is setting Flag value as 500.");
            celebrity2.Flag = 500;
        }
    }
}
