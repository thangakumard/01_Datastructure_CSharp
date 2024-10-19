using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructureMSTest.OOPs
{
    internal class HierarchialInheritance
    {
        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Animal is eating.");
            }
        }
        // hierarchical inheritance
        class Bird : Animal
        {
            public void Fly()
            {
                Console.WriteLine("Bird is flying.");
            }
        }

        class Eagle : Bird
        {
            public void Hunt()
            {
                Console.WriteLine("Eagle is hunting.");
            }
        }

        class Penguin : Bird
        {
            public void Swim()
            {
                Console.WriteLine("Penguin is swimming.");
            }
        }
    }
}
