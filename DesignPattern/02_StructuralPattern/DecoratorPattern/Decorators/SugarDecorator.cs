﻿using DesignPattern.StructuralPattern.DecoratorPattern.Decorators;
using DesignPattern.StructuralPattern.DecoratorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralPattern.DecoratorPattern.Decorators
{
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Sugar";
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.50;  // Additional cost for sugar
        }
    }

}
