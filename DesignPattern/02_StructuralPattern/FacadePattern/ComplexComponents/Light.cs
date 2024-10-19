using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralPattern.Facade.ComplexComponents
{
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Lights are turned on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Lights are turned off.");
        }
    }

}
