using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructureMSTest.OOPs
{
    internal class Overloading
    {
        public Overloading() { }
        public Overloading(string name) { } //constructor overloading


        // Method Overloading
        public void Print() {
            Console.WriteLine("Printing !");
        }

        // RETURN type cannot be used in the overloading
        //public String Print()
        //{
        //    Console.WriteLine("Printing !");
        //    return "Printing";
        //}

        public void Print(string s1)
        {
            Console.WriteLine("Printing !");
        }

        public void Print(bool b1)
        {
            Console.WriteLine("Printing !");
        }

        //**************************************************************/
        //Operator Overloading

        public class Complex
        {
            public int Real { get; set; }
            public int Imaginary { get; set; }

            public Complex(int real, int imaginary)
            {
                Real = real;
                Imaginary = imaginary;
            }

            // Overload the + operator to add two Complex numbers
            public static Complex operator +(Complex c1, Complex c2)
            {
                return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
            }

            public override string ToString()
            {
                return $"{Real} + {Imaginary}i";
            }
        }

        class Program
        {
            static void TestOperatorOverload()
            {
                Complex c1 = new Complex(1, 2);
                Complex c2 = new Complex(3, 4);
                Complex result = c1 + c2;  // Uses the overloaded + operator

                Console.WriteLine(result);  // Output: 4 + 6i
            }
        }

    }
}
