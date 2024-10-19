using DesignPattern.BehavioralPattern.ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehavioralPattern.ObserverPattern
{
    [TestClass]
    public class CheckWeatherApp
    {
            [TestMethod]
            public void GetWeather()
            {
                // Create the subject (WeatherStation)
                WeatherStation weatherStation = new WeatherStation();

                // Create an observer (CurrentConditionsDisplay)
                CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay();

                // Register the observer with the subject
                weatherStation.RegisterObserver(currentDisplay);

                // Update weather data
                weatherStation.SetMeasurements(25.0f, 65.0f, 1013.1f);  // Output: "Current conditions: 25°C, 65% humidity, 1013.1 hPa pressure."
                weatherStation.SetMeasurements(22.5f, 70.0f, 1012.8f);  // Output: "Current conditions: 22.5°C, 70% humidity, 1012.8 hPa pressure."

                // Remove the observer if needed
                // weatherStation.RemoveObserver(currentDisplay);
            }

    }
}
