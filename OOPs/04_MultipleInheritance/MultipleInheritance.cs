using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructureMSTest.OOPs._04_MultipleInheritance
{
    internal class MultipleInheritance
    {

        // multiple inheritance
        interface I1
        {
            void Method1();
        }

        interface I2
        {
            void Method2();
        }

        class MyClass : I1, I2
        {
            public void Method1()
            {
                Console.WriteLine("Method1 is called.");
            }

            public void Method2()
            {
                Console.WriteLine("Method2 is called.");
            }
        }
    }
}
