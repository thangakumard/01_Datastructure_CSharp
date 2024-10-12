using System.Collections.Concurrent;

namespace Collections.Specialized1
{

    [TestClass]
    public class Concurrent_ConcurrentQueue
    {
        [TestMethod]
        public void ConcurrentConcurrentQueue(){
           ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
        }
    }
}