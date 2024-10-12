using System.Collections.Concurrent;

namespace Collections.Specialized1
{

    [TestClass]
    public class Concurrent_ConcurrentStack
    {
        [TestMethod]
        public void ConcurrentConcurrentStack(){
          ConcurrentStack<int> stack = new ConcurrentStack<int>();
            stack.Push(1);
            stack.Push(2);
        }
    }
}