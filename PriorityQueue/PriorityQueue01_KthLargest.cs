namespace PriorityQueue;

[TestClass]
public class PriorityQueue01_KthLargest
{
    [TestMethod]
    public void kthLargest()
    {
       int[] input = {3,2,3,1,2,4,5,5,6};
       Assert.AreEqual(5, FindKthLargest(input, 2));
    }

    private int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int,int> minHeap = new PriorityQueue<int,int>();

        for(int i=0; i < nums.Length; i++){
            minHeap.Enqueue(nums[i], nums[i]);
            if(minHeap.Count > k){
                minHeap.Dequeue();
            }
        }
        return minHeap.Peek();
    }
}
