using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrays.Backtracking.Permutation
{
    /**
	 * Time: O(N!)
	 * Space: O(N)
	 */

     /***
 * https://leetcode.com/problems/permutations/
 * https://leetcode.com/problems/combination-sum/discuss/16502/A-general-approach-to-backtracking-questions-in-Java-(Subsets-Permutations-Combination-Sum-Palindrome-Partitioning)
 * 
 * Given an array nums of distinct integers, return all the possible
 * permutations. You can return the answer in any order.
 * 
 * Example 1:
 * Input: nums = [1,2,3] Output:
 * [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
 *
 * Example 2:
 * Input: nums = [0,1] Output: [[0,1],[1,0]]
 *
 * Example 3:
 * Input: nums = [1] Output: [[1]]
 * 
 * 
 * Constraints:
 * 
 * 1 <= nums.length <= 6 -10 <= nums[i] <= 10 All the integers of nums are
 * unique.
 * 
 */

    [TestClass]
    public class Permutations01_PossiblePermutations
    {
        [TestMethod]
        public void Permutations()
        {
            int[] input = {1,2,3,4};
            List<List<int>> result = PossiblePermutations(input);
            foreach(List<int> sets in result){
                Console.WriteLine("");
                foreach(int x in sets){
                    Console.Write(x);
                }
            }
        }
        private List<List<int>> PossiblePermutations(int[] nums) {
            List<List<int>> result = new List<List<int>>();
            BackTrackingHelper(result, nums, new List<int>());
            return result;
         }

         private void BackTrackingHelper(List<List<int>> result,int[] nums, List<int> temp){
            if(temp.Count == nums.Length){
                result.Add(new List<int>(temp));
                return;
            }
            for(int i=0; i < nums.Length; i++){
                if(temp.Contains(nums[i])) continue;
                temp.Add(nums[i]);
                BackTrackingHelper(result, nums, temp);
                temp.RemoveAt(temp.Count()-1);
            }
         }  
    }
}