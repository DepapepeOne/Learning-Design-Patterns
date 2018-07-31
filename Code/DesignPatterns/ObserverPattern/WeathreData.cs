using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Observer;
using ObserverPattern.Subject;

namespace ObserverPattern
{
    public class WeathreData : ISubject
    {
        private List<IObserver> observers;

        private float temperature;
        private float humidity;
        private float pressure;

        public WeathreData()
        {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            int i = observers.IndexOf(o);

            if (i >= 0)
            {
                observers.RemoveAt(i);
            }
        }

        public void NotifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                IObserver observer = observers[i];

                observer.Update(temperature, humidity, pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            MeasurementsChanged();
        }
    }
}
