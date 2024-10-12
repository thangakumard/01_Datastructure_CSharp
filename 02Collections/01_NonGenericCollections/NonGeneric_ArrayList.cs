using System;
using System.Collections;


namespace Collections.NonGeneric
{

    [TestClass]
    public class NonGeneric_ArrayList
    {
        /*
        Non-generic collections can store objects of any type. 
        These collections do not enforce type safety, 
        meaning you must cast the objects to their appropriate types when accessing them.*/
        [TestMethod]
        public void NonGenericArrayList(){
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Hello");
        }
    }
}