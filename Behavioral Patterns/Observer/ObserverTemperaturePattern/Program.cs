using System;

namespace ObserverTemperaturePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor provider = new ();
            TemperatureReporter observer1 = new();
            TemperatureReporter observer2 = new ();

            observer1.Subscribe(provider);
            observer2.Subscribe(provider);

            provider.GetTemperature();

            Console.ReadKey();
            
        }
    }
}
