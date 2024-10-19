using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructureMSTest.OOPs
{
    /*
     * In C#, a sealed class is a class that cannot be inherited. 
     * When a class is marked as sealed, it prevents other classes from deriving from it, 
     * making it a final class in the inheritance hierarchy.
     */
    internal class SealedClass
    {
    public sealed class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(10, 5));        // Output: 15
            Console.WriteLine(calc.Subtract(10, 5));   // Output: 5
        }
    }

}
}
