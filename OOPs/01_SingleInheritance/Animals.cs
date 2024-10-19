using OOPs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.SingleInheritance
{
    internal class Animals : LivingBeing
    {
        public bool CanRun(bool walk)
        {
            if (walk) {
                Console.WriteLine("Yes ! This animal can walk!");
            }
            else
            {
                Console.WriteLine("No ! This animail cannot walk");
            }
            return walk;
        }
    }
}
