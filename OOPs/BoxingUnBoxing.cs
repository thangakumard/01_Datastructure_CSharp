using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructureMSTest.OOPs
{
    internal class BoxingUnBoxing
    {
            public void Boxing()
            {
                int i = 10;
                object o = i;
            }

            public void UnBoxing()
            {
                object o = 222;
                int i = (int)o;
            }
    }
}
