using System;
using System.Collections;

namespace Arrays.Backtracking.Subsets
{

    [TestClass]
    public class SubsetsWithoutDuplicate
    {
        [TestMethod]
        public void Subsets()
        {
            int[] input = {1,2,3,4};
            IList<IList<int>> result = GetSubsets(input);
            foreach(List<int> sets in result){
                Console.WriteLine("");
                foreach(int x in sets){
                    Console.Write(x);
                }
            }
        }
        private IList<IList<int>> GetSubsets(int[] nums) {
            IList<IList<int>> result = new List<IList<int>>();
            BackTrackingHelper(result, nums, new List<int>(), 0);
            return result;
    }

    private void BackTrackingHelper(IList<IList<int>> result, int[] nums, IList<int> temp, int start){
        result.Add(new List<int>(temp));

        for(int i=start; i < nums.Length; i++){
            temp.Add(nums[i]);
            BackTrackingHelper(result,nums, temp, i+1);
            temp.RemoveAt(temp.Count-1);
        }
    }
    }
}