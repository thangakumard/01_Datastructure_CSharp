using System;
using System.Collections;


namespace DataTypes
{

    [TestClass]
    public class MinMaxValues
    {
        [TestMethod]
        public void MinMaxValues01(){
            Console.WriteLine("Int32.MinValue :" + Int32.MinValue);
            Console.WriteLine("Int32.MaxValue :" + Int32.MaxValue);

            Console.WriteLine("Int64.MinValue :" + Int64.MinValue);
            Console.WriteLine("Int64.MaxValue :" + Int64.MaxValue);

            Console.WriteLine("float.MinValue :" + float.MinValue);
            Console.WriteLine("float.MaxValue :" + float.MaxValue);
        }
    }
}