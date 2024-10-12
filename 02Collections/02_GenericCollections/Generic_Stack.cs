using System.Collections;

namespace Collections.Generic
{

    [TestClass]
    public class Generic_Stack
    {
        [TestMethod]
        public void GenericStack(){
          Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
        }
    }
}