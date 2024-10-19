using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._01_CreationalPattern.Singleton
{
    public class SingletonThreadUnsafe
    {
            // Private static instance of the Singleton class
            private static SingletonThreadUnsafe _instance;

            // Private constructor to prevent external instantiation
            private SingletonThreadUnsafe()
            {
                // Private constructor ensures no external instantiation
            }

            // Public static method to get the Singleton instance
            public static SingletonThreadUnsafe Instance
            {
                get
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonThreadUnsafe();
                    }
                    return _instance;
                }
            }

            public void DoSomething()
            {
                Console.WriteLine("Singleton instance is doing something.");
            }

    }
}
