using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._01_CreationalPattern.Singleton
{
    internal class LazySingleton
    {
        // Lazy<T> ensures thread-safe lazy initialization
        private static readonly Lazy<LazySingleton> _instance 
            = new Lazy<LazySingleton>(() => new LazySingleton());

        // Private constructor to prevent external instantiation
        private LazySingleton() { }

        // Access the Singleton instance
        public static LazySingleton Instance => _instance.Value;

        public void DoSomething()
        {
            Console.WriteLine("Lazy Singleton instance is doing something.");
        }
    }

}
