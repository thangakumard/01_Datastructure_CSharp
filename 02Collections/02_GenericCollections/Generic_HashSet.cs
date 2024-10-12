using System.Collections;

namespace Collections.Generic
{

    [TestClass]
    public class Generic_HashSet
    {
        [TestMethod]
        public void GenericHashSet(){
            HashSet<int> set = new HashSet<int> { 1, 2, 3 };
            set.Add(2);  // Duplicate, won't be added
        }
    }
}