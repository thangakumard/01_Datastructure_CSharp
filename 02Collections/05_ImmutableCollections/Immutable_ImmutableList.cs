using System.Collections.Concurrent;
using System.Collections.Immutable;

namespace Collections.Immutable1
{

    [TestClass]
    public class Immutable_ImmutableList
    {
        [TestMethod]
        public void ImmutableImmutableList(){
           var immutableList = ImmutableList.Create(1, 2, 3);
        }
    }
}