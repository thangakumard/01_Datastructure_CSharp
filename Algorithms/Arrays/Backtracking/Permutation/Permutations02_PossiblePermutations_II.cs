using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Arrays.Backtracking.Permutation
{
    /**
	 * Time: O(N∗N!)
	 * Space: O(N)
	 */

     /***
 * https://leetcode.com/problems/permutations-ii/
 * https://leetcode.com/problems/combination-sum/discuss/16502/A-general-approach-to-backtracking-questions-in-Java-(Subsets-Permutations-Combination-Sum-Palindrome-Partitioning)
 * 
 *  Given a collection of numbers,
 * nums, that might contain duplicates, return all possible unique permutations
 * in any order.
 * 
 * Example 1:
 * Input: nums = [1,1,2]
 * Output: [[1,1,2], [1,2,1], [2,1,1]]
 *
 * Example 2:
 * Input: nums = [1,2,3]
 * Output:
 * [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
 * 
 * 
 * Constraints:
 * 
 * 1 <= nums.length <= 8 -10 <= nums[i] <= 10
 * 
 */
     
    [TestClass]
    public class Permutations02_PossiblePermutations_II
    {
        [TestMethod]
        public void Permutations()
        {
            int[] input = {1,2,3,4};
            List<List<int>> result = PossiblePermutationsHandlesDuplicate(input);
            foreach(List<int> sets in result){
                Console.WriteLine("");
                foreach(int x in sets){
                    Console.Write(x);
                }
            }
        }
        private List<List<int>> PossiblePermutationsHandlesDuplicate(int[] nums) {
            List<List<int>> result = new List<List<int>>();
            List<bool> used = new List<bool>();
            Array.Sort(nums);
            BackTrackingHelper(result, nums, new List<int>(),used);
            return result;
         }

         private void BackTrackingHelper(List<List<int>> result,int[] nums, List<int> temp, List<bool> used){
            if(temp.Count == nums.Length){
                result.Add(new List<int>(temp));
                return;
            }
            for(int i=0; i < nums.Length; i++){
                if(used[i] || (i > 0 && nums[i] == nums[i-1]  && !used[i-1])) continue;
                temp.Add(nums[i]);
                used[i] = true;
                BackTrackingHelper(result, nums, temp, used);
                temp.RemoveAt(temp.Count()-1);
                used[i] = false;
            }
         }  
    }
}