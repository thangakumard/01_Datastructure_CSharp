using DesignPattern.StructuralPattern.DecoratorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralPattern.DecoratorPattern.Decorators
{
    public class CoffeeDecorator : ICoffee
    {
        protected ICoffee _coffee;

        // The decorator has a reference to the object it decorates
        public CoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public virtual string GetDescription()
        {
            return _coffee.GetDescription();
        }

        public virtual double GetCost()
        {
            return _coffee.GetCost();
        }
    }
}
