using System;
using System.Collections;

namespace Collections
{

    [TestClass]
    public class ArrayListSample
    {
        [TestMethod]
        public void MyArrayList()
        {
            ArrayList al = new ArrayList();

            Console.WriteLine("Adding some numbers:");
            al.Add(45);
            al.Add(78);
            al.Add(33);
            al.Add(56);
            al.Add(12);
            al.Add(23);
            al.Add(9);
            al.Add(23);
            al.Add(9);

            Console.WriteLine("Capacity: {0} ", al.Capacity);
            Console.WriteLine("Count: {0}", al.Count);

            Console.Write("Content: ");
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }

            ///Sorting
            Console.WriteLine();
            Console.Write("Sorted Content: ");
            al.Sort();
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //ArrayList To Array 
            int[] input = al.OfType<int>().ToArray();
            Console.Write("Array List to Array: ");
            foreach (int i in input)
            {
                Console.Write(i + " ");
            }
        }
    }
}
