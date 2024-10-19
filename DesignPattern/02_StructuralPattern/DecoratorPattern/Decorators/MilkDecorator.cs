using DesignPattern.StructuralPattern.DecoratorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralPattern.DecoratorPattern.Decorators
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Milk";
        }

        public override double GetCost()
        {
            return base.GetCost() + 1.50;  // Additional cost for milk
        }
    }

}
