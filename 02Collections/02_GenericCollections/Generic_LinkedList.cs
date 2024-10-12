using System.Collections;

namespace Collections.Generic
{

    [TestClass]
    public class Generic_LinkedList
    {
        [TestMethod]
        public void GenericLinkedList(){
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);

        }
    }
}