using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Display;
using ObserverPattern.Subject;

namespace ObserverPattern.Observer
{
    public class StatisticsDisplay : IObserver, IDisplay
    {
        private float temperature;
        private float humidity;
        private float pressure;

        private ISubject weatherData;

        public StatisticsDisplay(ISubject subject)
        {
            weatherData = subject;

            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            Display();
        }

        public void Display()
        {
            Console.WriteLine(string.Format("Avg/Max/Min temperature = {0}/{0}/{0}", temperature));
        }
    }
}
