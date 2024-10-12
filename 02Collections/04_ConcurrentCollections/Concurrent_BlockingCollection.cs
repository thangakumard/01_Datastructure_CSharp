using System.Collections.Concurrent;

namespace Collections.Specialized1
{

    [TestClass]
    public class Concurrent_BlockingCollection
    {
        [TestMethod]
        public void ConcurrentBlockingCollection(){
           BlockingCollection<int> blockingCollection = new BlockingCollection<int>(5);
            blockingCollection.Add(1);
            blockingCollection.Add(2);
        }
    }
}