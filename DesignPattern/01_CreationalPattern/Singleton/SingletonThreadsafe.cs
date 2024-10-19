using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._01_CreationalPattern.Singleton
{
    internal class SingletonThreadsafe
    {
            private static SingletonThreadsafe _instance;
            private static readonly object _lock = new object();

            // Private constructor to prevent external instantiation
            private SingletonThreadsafe() { }

            // Thread-safe Singleton instance creation
            public static SingletonThreadsafe Instance
            {
                get
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new SingletonThreadsafe();
                        }
                        return _instance;
                    }
                }
            }

            public void DoSomething()
            {
                Console.WriteLine("Thread-Safe Singleton instance is doing something.");
            }

    }
}
