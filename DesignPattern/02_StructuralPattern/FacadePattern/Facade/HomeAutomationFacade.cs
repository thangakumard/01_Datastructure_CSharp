using DesignPattern.StructuralPattern.Facade.ComplexComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralPattern.FacadePattern.Facade
{
    public class HomeAutomationFacade
    {
        private readonly Light _light;
        private readonly Thermostat _thermostat;
        private readonly SecurityCamera _securityCamera;

        public HomeAutomationFacade(Light light, Thermostat thermostat, SecurityCamera securityCamera)
        {
            _light = light;
            _thermostat = thermostat;
            _securityCamera = securityCamera;
        }

        // Simplified method to leave home
        public void LeaveHome()
        {
            Console.WriteLine("Leaving home...");
            _light.TurnOff();
            _thermostat.SetTemperature(15);  // Lower temperature
            _securityCamera.TurnOn();        // Turn on security cameras
            Console.WriteLine("Home is now secured.");
        }

        // Simplified method to arrive home
        public void ArriveHome()
        {
            Console.WriteLine("Arriving home...");
            _light.TurnOn();
            _thermostat.SetTemperature(22);  // Raise temperature for comfort
            _securityCamera.TurnOff();       // Turn off security cameras
            Console.WriteLine("Welcome home!");
        }
    }

}
