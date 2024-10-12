using System.Collections;

namespace Collections.Generic
{

    [TestClass]
    public class Generic_Queue
    {
        [TestMethod]
        public void GenericQueue(){
          Queue<string> queue = new Queue<string>();
          queue.Enqueue("first");
          queue.Enqueue("second");
        }
    }
}