using System;
using System.Collections;


namespace Collections.NonGeneric
{
    [TestClass]
    public class NonGeneric_Stack
    {
        /*
        Non-generic collections can store objects of any type. 
        These collections do not enforce type safety, 
        meaning you must cast the objects to their appropriate types when accessing them.*/
       [TestMethod]
        public void NonGenericStack(){
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
        }
    }
}