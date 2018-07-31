using ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Observer;

namespace ObserverPatternConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WeathreData weatherData = new WeathreData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);


            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);


            Console.ReadKey();
        }
    }
}
