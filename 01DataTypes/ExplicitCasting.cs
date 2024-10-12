using System;
using System.Collections;

namespace DataTypes
{

    [TestClass]
    public class ExplicitCasting
    {
        /*
        Explicit casting is required when there's a potential for data loss or precision loss, 
        such as when converting from a larger data type to a smaller one. 
        This must be done explicitly by the programmer.
        Supported Types:
            larger to smaller types:
                double to int
                long to int
                float to int
        */

        [TestMethod]
        public void TypeConversionMethods(){
            /*
                Convert.ToInt32(): Converts to int.
                Convert.ToDouble(): Converts to double.
                Convert.ToString(): Converts to string.
                Convert.ToBoolean(): Converts to bool.
                Convert.ToChar(): Converts to char.
            */
            string str = "123";
            int num = Convert.ToInt32(str);  // Converts string to int
            num = Convert.ToInt32(null);
            Console.WriteLine("num is :" + num);

            double dbl = 12.34;
            string strDouble = Convert.ToString(dbl);
        }

        [TestMethod]
        public void UsingParsing(){
            //Parse throws an exception if the conversion fails.
            string str = "123";
            int num = int.Parse(str);  // Converts string to int

        }
        [TestMethod]
        public void UsingTryParsing(){
            //TryParse is a safer way to parse strings, as it does not throw an exception if the conversion fails. 
            // Instead, it returns true if the conversion was successful and false if it failed.
            
            string str = "123";
            int num;
            bool success = int.TryParse(str, out num);  // Safe conversion
            if (success)
            {
                Console.WriteLine("Conversion successful: " + num);
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }
        }

        [TestMethod]
        public void UsingBoxingUnBoxing(){
            /*
            Boxing: Converts a value type (e.g., int) into an object type (reference type).
            Unboxing: Converts an object type back into a value type.
            */
            int num = 123;
            object obj = num;  // Boxing: int to object
            int unboxedNum = (int)obj;  // Unboxing: object to int
        }
    }
}