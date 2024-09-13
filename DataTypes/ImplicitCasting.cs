using System;
using System.Collections;

namespace DataTypes
{

    [TestClass]
    public class ImplicitCasting
    {
            [TestMethod]
            public void Sample01(){
            /*
            Implicit casting is done by the compiler when no data will be lost in the conversion. 
            It's generally safe and does not require manual intervention.
            Supported Types:
                        smaller to larger types:
                                int to long
                                float to double
                                char to int
            No data loss occurs, and C# performs this conversion automatically.
            */
            int num = 100;
            double dbl = num;  // Implicitly cast from int to double
        }
    }
}