using System;
using System.Collections;


namespace Collections.NonGeneric
{
    [TestClass]
    public class NonGeneric_Queue
    {
        /*
        Non-generic collections can store objects of any type. 
        These collections do not enforce type safety, 
        meaning you must cast the objects to their appropriate types when accessing them.*/
        [TestMethod]
        public void NonGenericQueue(){
            Queue queue = new Queue();
            queue.Enqueue("first");
            queue.Enqueue("second");
        }
    }
}