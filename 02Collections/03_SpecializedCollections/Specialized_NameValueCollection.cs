using System.Collections;
using System.Collections.Specialized;

namespace Collections.Specialized
{

    [TestClass]
    public class Specialized_NameValueCollection
    {
        /*NameValueCollection: Represents a collection of associated String keys and String values 
        that can be accessed either with the key or with the index.
        */
        [TestMethod]
        public void SpecializedNameValueCollection(){
            NameValueCollection nameValues = new NameValueCollection();
            nameValues.Add("Key1", "Value1");
            nameValues.Add("Key2", "Value2");
        }
    }
}