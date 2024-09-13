using System;
using System.Collections;

namespace DataTypes
{

    [TestClass]
    public class DataTypeExamples
    {
        [TestMethod]
        public void sample01()
        {
            // Integral Types
        byte byteVar = 255;
        int intVar = 123456;
        long longVar = 1234567890123456789L;

        // Floating-Point Types
        float floatVar = 3.14f;
        double doubleVar = 3.141592653589793;
        decimal decimalVar = 123.45m;

        // Boolean Type
        bool boolVar = true;

        // Character Type
        char charVar = 'A';

        // String Type
        string stringVar = "Hello, World!";

        // Array Type
        int[] intArray = { 1, 2, 3, 4, 5 };

        // Object Type
        object objVar = "I am an object";

        // Output
        Console.WriteLine($"Byte: {byteVar}");
        Console.WriteLine($"Int: {intVar}");
        Console.WriteLine($"Long: {longVar}");
        Console.WriteLine($"Float: {floatVar}");
        Console.WriteLine($"Double: {doubleVar}");
        Console.WriteLine($"Decimal: {decimalVar}");
        Console.WriteLine($"Boolean: {boolVar}");
        Console.WriteLine($"Char: {charVar}");
        Console.WriteLine($"String: {stringVar}");
        Console.WriteLine($"Array First Element: {intArray[0]}");
        Console.WriteLine($"Object: {objVar}");
        }
    }
}