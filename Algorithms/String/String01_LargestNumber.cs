using System;
using System.Collections;

namespace Algorithms.String.Substring
{

    [TestClass]
    public class String01_LargestNumber
    {
        [TestMethod]
        public void Subsets()
        {
            int[] input = {1,2,3,4};
            Console.WriteLine("Output :" + GetLargestNumber(input));
        }
        private class LargerNumberComparator : IComparer<string>
        {
            public int Compare(string? a, string? b)
            {
                string order1 = a + b;
                string order2 = b + a;
                return order2.CompareTo(order1);
            }
        }
        public string GetLargestNumber(int[] nums)
        {
            // Convert integers to strings.
            string[] asStrs = nums.Select(num => num.ToString()).ToArray();

            // Sort strings according to custom comparator.
            Array.Sort(asStrs, new LargerNumberComparator());

            // If, after being sorted, the largest number is "0", the entire number is zero.
            if (asStrs[0] == "0")
            {
                return "0";
            }

            // Build largest number from sorted array.
            string largestNumberStr = string.Join("", asStrs);

            return largestNumberStr;
        }
    }
}