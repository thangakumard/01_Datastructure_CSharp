using System.Collections;

namespace Collections.Generic
{

    [TestClass]
    public class Generic_List
    {
        [TestMethod]
        public void GenericList(){
           List<int> numbers = new List<int> { 1, 2, 3 };
            numbers.Add(4);
        }
    }
}