using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralPattern.Facade.ComplexComponents
{
    public class SecurityCamera
    {
        public void TurnOn()
        {
            Console.WriteLine("Security cameras are turned on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Security cameras are turned off.");
        }
    }

}
