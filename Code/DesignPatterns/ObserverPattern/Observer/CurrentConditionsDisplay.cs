using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Display;
using ObserverPattern.Subject;

namespace ObserverPattern.Observer
{
    public class CurrentConditionsDisplay : IObserver, IDisplay
    {
        private float tempreature;
        private float humidity;
        private float pressure;

        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;

            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + tempreature + " F degress and " + humidity + "% humidity");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.tempreature = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            Display();
        }
    }
}
