using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructureMSTest.OOPs
{
    internal class MultiLevelInheritance
    {
        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Animal is eating.");
            }
        }
        // multi-level inheritance
        class Mammal : Animal
        {
            public void Run()
            {
                Console.WriteLine("Mammal is running.");
            }
        }

        class Horse : Mammal
        {
            public void Gallop()
            {
                Console.WriteLine("Horse is galloping.");
            }
        }
    }
}
