using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms.Arrays.Backtracking.Combination
{
    [TestClass]
    public class Combinations02_Sum
    {
        [TestMethod]
        public void Subsets()
        {
            int[] input = {1,1,2,3,4};
            List<List<int>> result = GetCombinationSum(input,5);
            foreach(List<int> sets in result){
                Console.WriteLine("");
                foreach(int x in sets){
                    Console.Write(x);
                }
            }
        }
        private List<List<int>> GetCombinationSum(int[] nums, int sum) {
            List<List<int>> result = new List<List<int>>();
            BackTrackingHelper(result, nums, new List<int>(), sum, 0);
            return result;
         }

         private void BackTrackingHelper(List<List<int>> result, int[] nums, List<int> temp, int remaining, int start){
            if (remaining < 0)
			    return;
            if(remaining == 0){
                result.Add(new List<int>(temp));
            }else{
                for(int i=start; i < nums.Length; i++){
                    temp.Add(nums[i]);
                    remaining -= nums[i];
                    BackTrackingHelper(result, nums, temp, remaining, i);
                    remaining += nums[i];
                    temp.RemoveAt(temp.Count-1);
                }
            }
            
         }
    }
}