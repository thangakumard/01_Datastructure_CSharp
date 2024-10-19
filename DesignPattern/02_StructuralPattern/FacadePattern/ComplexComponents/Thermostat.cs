using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralPattern.Facade.ComplexComponents
{
    public class Thermostat
    {
        public void SetTemperature(int temperature)
        {
            Console.WriteLine($"Thermostat set to {temperature} degrees.");
        }
    }

}
