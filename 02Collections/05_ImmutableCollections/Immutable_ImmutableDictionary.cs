using System.Collections.Immutable;

namespace Collections.Immutable1
{

    [TestClass]
    public class Immutable_ImmutableDictionary
    {
        [TestMethod]
        public void ImmutableImmutableDictionary(){
           var immutableDict = ImmutableDictionary.Create<int, string>();
        }
    }
}