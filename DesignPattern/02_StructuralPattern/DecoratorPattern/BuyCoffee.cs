using DesignPattern.StructuralPattern.DecoratorPattern.Decorators;
using DesignPattern.StructuralPattern.DecoratorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralPattern.DecoratorPattern
{
    [TestClass]
    public class BuyCoffee
    {
        [TestMethod]
        public void CheckoutCoffee()
        {
            // Start with a simple coffee
            ICoffee coffee = new SimpleCoffee();
            Console.WriteLine($"{coffee.GetDescription()} : ${coffee.GetCost()}");

            // Add milk to the coffee
            coffee = new MilkDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} : ${coffee.GetCost()}");

            // Add sugar to the coffee
            coffee = new SugarDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} : ${coffee.GetCost()}");

            // Add more milk (nested decorators)
            coffee = new MilkDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} : ${coffee.GetCost()}");
        }
    
    }
}
