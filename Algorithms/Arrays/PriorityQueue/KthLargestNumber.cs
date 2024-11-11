using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms.Arrays.PriorityQueue
{
    [TestClass]
    public class KthLargestNumber
    {
        [TestMethod]
        public int FindKthLargest(int[] nums, int k)
        {
            // PriorityQueue in .NET: Smallest elements are prioritized
            PriorityQueue<int, int> minQueue = new PriorityQueue<int, int>();

            foreach (var num in nums)
            {
                minQueue.Enqueue(num, num); // Add element with priority
                if (minQueue.Count > k) // Maintain only k elements in the queue
                {
                    minQueue.Dequeue(); // Remove the smallest element
                }
            }

            return minQueue.Dequeue(); // The kth largest element
        }
    }


}