/*Define an IDisposable implementation that the provider can return to
 * subscribers so that they can stop receiving notifications at any time. 
 * The following example defines a nested Unsubscriber class that is passed a 
 * reference to the subscribers collection and to the subscriber when the
 * class is instantiated. This code enables the subscriber to call the 
 * object's IDisposable.Dispose implementation to remove itself from the 
 * subscribers collection.
 * */
using System;
using System.Collections.Generic;

namespace ObserverTemperaturePattern
{
    public class Unsubscriber : IDisposable
    {
        private List<IObserver<Temperature>> _observers;
        private IObserver<Temperature> _observer;

        public Unsubscriber(List<IObserver<Temperature>> observers, IObserver<Temperature> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (!(_observer == null)) _observers.Remove(_observer);
        }
    }
}