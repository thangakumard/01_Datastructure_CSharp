using System.Collections.Concurrent;

namespace Collections.Specialized1
{

    [TestClass]
    public class Concurrent_ConcurrentDictionary
    {
        [TestMethod]
        public void ConcurrentConcurrentDictionary(){
           ConcurrentDictionary<int, string> dict = new ConcurrentDictionary<int, string>();
            dict.TryAdd(1, "One");
            dict.TryAdd(2, "Two");
        }
    }
}