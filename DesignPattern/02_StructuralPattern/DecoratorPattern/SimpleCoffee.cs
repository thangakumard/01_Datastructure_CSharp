using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralPattern.DecoratorPattern
{
    internal class SimpleCoffee : ICoffee
    {
        public string GetDescription()
        {
            return "Simple Coffee";
        }

        public double GetCost()
        {
            return 5.00;
        }
    }
}
