using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;


/***
 * https://leetcode.com/problems/subsets-ii/
 * https://leetcode.com/problems/combination-sum/discuss/16502/A-general-approach-to-backtracking-questions-in-Java-(Subsets-Permutations-Combination-Sum-Palindrome-Partitioning)
 * 
 * Given a collection of integers that might contain duplicates, nums, return
 * all possible subsets (the power set).
 * 
 * Note: The solution set must not contain duplicate subsets.
 * 
 * Example:
 * 
 * Input: [1,2,2] Output: [ [2], [1], [1,2,2], [2,2], [1,2], [] ]
 */

namespace Algorithms.Arrays.Backtracking.Subsets
{
    [TestClass]
    public class Subset01_SubsetsWithDuplicate
    {
        [TestMethod]
        public void Subsets()
        {
            int[] input = {1,2,2};
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
            Array.Sort(nums);
            BackTrackingHelper(result, nums, new List<int>(), 0);
            return result;
         }

         private void BackTrackingHelper(IList<IList<int>> result, int[] nums,List<int> temp , int start){
            result.Add(new List<int>(temp));
            for(int i= start; i < nums.Length; i++){
                if(i > start && nums[i-1] == nums[i]) continue;
              temp.Add(nums[i]);
              BackTrackingHelper(result, nums,temp, i+1);
              temp.RemoveAt(temp.Count-1);
            }
         }
    }
}