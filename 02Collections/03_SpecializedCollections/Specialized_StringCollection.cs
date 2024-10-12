using System.Collections;
using System.Collections.Specialized;

namespace Collections.Specialized
{

    [TestClass]
    public class Specialized_StringCollection
    {
        /*NameValueCollection: Represents a collection of associated String keys and String values 
        that can be accessed either with the key or with the index.
        */
        [TestMethod]
        public void SpecializedStringCollection(){
           StringCollection strings = new StringCollection();
            strings.Add("First");
            strings.Add("Second");
        }
    }
}