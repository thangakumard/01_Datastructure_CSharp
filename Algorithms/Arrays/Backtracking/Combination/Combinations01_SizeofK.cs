using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms.Arrays.Backtracking.Combination
{
    [TestClass]
    public class Combinations01_SizeofK
    {
        [TestMethod]
        public void Subsets()
        {
            int[] input = {1,2,3,4};
            List<List<int>> result = GetCombinations(input,2);
            foreach(List<int> sets in result){
                Console.WriteLine("");
                foreach(int x in sets){
                    Console.Write(x);
                }
            }
        }
        private List<List<int>> GetCombinations(int[] nums, int k) {
            List<List<int>> result = new List<List<int>>();
            BackTrackingHelper(result, nums, k, new List<int>(), 0);
            return result;
         }

         private void BackTrackingHelper(List<List<int>> result, int[] nums, int k, List<int> temp, int start){
            if(temp.Count == k){
                result.Add(new List<int>(temp));
            }else{
                for(int i=start; i < nums.Length; i++){
                    temp.Add(nums[i]);
                    BackTrackingHelper(result,nums,k,temp,i+1);
                    temp.RemoveAt(temp.Count-1);
                }
            }
         }

    }
}