using System;
using System.Collections;

namespace DataTypes
{
    /*
    Reference types store a reference to the data and are typically stored on the heap. They include:
    
    String Type:
    string: Represents a sequence of characters.

    Class Types:
    class: A blueprint for objects. Example: class MyClass { }.

    Interface Types:
    interface: A contract that classes can implement. Example: interface IExample { }.

    Array Types:
    Arrays: Fixed-size collection of elements of the same type. Example: int[] numbers = new int[5];
    .
    Delegate Types:
    delegate: Type that represents references to methods with a particular parameter list and return type. Example: delegate void MyDelegate(string message);.
    
    Object Type:
    object: The base type from which all other types derive. Example: object obj = 42;.
    */

    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void sample01()
        {
            // String Type
        string stringVar = "Hello, World!";

        // Array Type
        int[] intArray = { 1, 2, 3, 4, 5 };

        // Object Type
        object objVar = "I am an object";

            Console.WriteLine($"String: {stringVar}");
            Console.WriteLine($"Array First Element: {intArray[0]}");
            Console.WriteLine($"Object: {objVar}");
        }
    }
}