using System;
using System.Collections;


namespace Collections.NonGeneric
{

    [TestClass]
    public class NonGeneric_Hashtable
    {
        /*
        Non-generic collections can store objects of any type. 
        These collections do not enforce type safety, 
        meaning you must cast the objects to their appropriate types when accessing them.*/
        [TestMethod]
        public void NonGenericHashtable(){
            Hashtable table = new Hashtable();
            table.Add(1, "One");
            table.Add(2, "Two");
        }
    }
}