using System;
using System.Collections;

namespace DataTypes
{
    /*
    byte: 8-bit unsigned integer (0 to 255).
    sbyte: 8-bit signed integer (-128 to 127).
    short: 16-bit signed integer (-32,768 to 32,767).
    ushort: 16-bit unsigned integer (0 to 65,535).
    int: 32-bit signed integer (-2,147,483,648 to 2,147,483,647).
    uint: 32-bit unsigned integer (0 to 4,294,967,295).
    long: 64-bit signed integer (-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807).
    ulong: 64-bit unsigned integer (0 to 18,446,744,073,709,551,615).
    */

    [TestClass]
    public class ValueTypes
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

       
        // Output
        Console.WriteLine($"Byte: {byteVar}");
        Console.WriteLine($"Int: {intVar}");
        Console.WriteLine($"Long: {longVar}");
        Console.WriteLine($"Float: {floatVar}");
        Console.WriteLine($"Double: {doubleVar}");
        Console.WriteLine($"Decimal: {decimalVar}");
        Console.WriteLine($"Boolean: {boolVar}");
        Console.WriteLine($"Char: {charVar}");
        }
    }
}