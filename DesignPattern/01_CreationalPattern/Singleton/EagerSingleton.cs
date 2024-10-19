using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._01_CreationalPattern.Singleton
{
    internal class EagerSingleton
    {
            // Instance is created as soon as the class is loaded
            private static readonly EagerSingleton _instance = new EagerSingleton();

            // Private constructor
            private EagerSingleton() { }

            // Public property to access the Singleton instance
            public static EagerSingleton Instance => _instance;

            public void DoSomething()
            {
                Console.WriteLine("Eager Singleton instance is doing something.");
            }

    }
}
