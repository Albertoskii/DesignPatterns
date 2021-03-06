using System;
using System.Collections.Generic;

namespace AirportBaggage
{
    public class Program
    {
        public static void Main()
        {
            BaggageHandler provider = new ();
            ArrivalsMonitor observer1 = new ("Baggage Claim Monitor 1");
            ArrivalsMonitor observer2 = new ("Security Exit");

            provider.BaggageStatus(712, "Detroit", 3);
            observer1.Subscribe(provider);
            provider.BaggageStatus(712, "Kalamazoo", 3);
            provider.BaggageStatus(400, "New York-Kennedy", 1);
            provider.BaggageStatus(712, "Detroit", 3);
            observer2.Subscribe(provider);
            provider.BaggageStatus(511, "San Francisco", 2);
            provider.BaggageStatus(712);
            observer2.Unsubscribe();
            provider.BaggageStatus(400);
            provider.LastBaggageClaimed();
        }
    }
}