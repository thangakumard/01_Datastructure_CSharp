using DesignPattern.StructuralPattern.DecoratorPattern.Decorators;
using DesignPattern.StructuralPattern.DecoratorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralPattern.DecoratorPattern
{
    /*
     * 
     * The Decorator Pattern is a structural design pattern that allows behavior to be added to individual objects, either statically or dynamically, without affecting the behavior of other objects from the same class. It is typically used to extend the functionalities of classes in a flexible and reusable way.

        In C#, the Decorator Pattern provides an alternative to subclassing by allowing you to add functionality to an object at runtime. It works by creating a set of decorator classes that are used to wrap concrete components.

        Key Concepts of the Decorator Pattern:
        
        Component: This is the base interface or abstract class that defines the common behavior for both the concrete components and decorators.
        Concrete Component: The class that is being decorated with additional functionality.
        Decorator: A class that implements or extends the Component and adds extra behavior while delegating tasks to the concrete component.
        Concrete Decorators: These are specific decorators that add or override behavior of the ConcreteComponent.
     */
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
