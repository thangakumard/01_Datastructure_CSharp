using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructureMSTest.OOPs
{
    /*
     * In C#, an abstract class is a class that cannot be instantiated directly.
     * It is intended to be a base class for other classes to derive from. 
     * Abstract classes can contain abstract methods (methods without implementation), 
     * concrete methods (methods with implementation), and fields. 
     * The main purpose of an abstract class is to provide a common blueprint for derived classes, 
     * which must implement the abstract members.
     * */
    public abstract class Vechicle
    {
        public abstract string Name { get; }
        public abstract void GoFast();

        public void Stop()
        {
            Console.WriteLine("Sopping the Vechicle!");
        }
    }

    public class Car : Vechicle
    {
        public override string Name { get{ return "Civic car"; } }

        public override void GoFast()
        {
            Console.WriteLine("The car is going fast !");
        }
    }
}
