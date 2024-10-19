using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehavioralPattern.ObserverPattern
{
    public class CurrentConditionsDisplay : IObserver
    {
        private float temperature;
        private float humidity;
        private float pressure;

        // This class is an observer that gets updated by the WeatherStation
        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }

        // Method to display the current conditions
        public void Display()
        {
            Console.WriteLine($"Current conditions: {temperature}°C, {humidity}% humidity, {pressure} hPa pressure.");
        }
    }

}
