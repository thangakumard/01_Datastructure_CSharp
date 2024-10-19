using OOPs.SingleInheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    [TestClass]
    public class OOPsTestFile
    {
        [TestMethod]
        public void TestSingleInheritance()
        {
            Animals animal = new Animals();
            animal.Breath();
            animal.Grow();
            animal.CanRun(true);
        }
    }
}
