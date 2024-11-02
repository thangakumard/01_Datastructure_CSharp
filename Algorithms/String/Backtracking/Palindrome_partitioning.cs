

namespace Algorithms.String.Backtracking
{
    /**
    * https://leetcode.com/problems/palindrome-partitioning/
    * https://leetcode.com/problems/combination-sum/discuss/16502/A-general-approach-to-backtracking-questions-in-Java-(Subsets-Permutations-Combination-Sum-Palindrome-Partitioning)
    * 
    * Given a string s, partition s such that every substring of the partition is a
    * palindrome. Return all possible palindrome partitioning of s.
    * 
    * A palindrome string is a string that reads the same backward as forward.
    * 
    * 
    * 
    * Example 1:
    * 
    * Input: s = "aab" Output: [["a","a","b"],["aa","b"]] Example 2:
    * 
    * Input: s = "a" Output: [["a"]]
    * 
    * 
    * Constraints:
    * 
    * 1 <= s.length <= 16 s contains only lowercase English letters.
    */

    [TestClass]
    public class Palindrome_partitioning
    {
        [TestMethod]
        public void Partition() {
                string s = "aab";
                IList<IList<string>> result = new List<IList<string>>();
                backTracking(result, s, new List<string>(), 0);
                foreach(List<string> sets in result){
                    Console.WriteLine("");
                    foreach(string x in sets){
                        Console.Write(x);
                    }
                }
            }
        

        private void backTracking(IList<IList<string>> result, string s, 
            List<string> temp, int start){
            if(start == s.Length){
                result.Add(new List<string>(temp));
            }else
                for(int i=start; i < s.Length; i++){
                    if(isPalindrome(s, start, i)){
                        temp.Add(s.Substring(start, i-start+1));
                        backTracking(result, s, temp, i+1);
                        temp.RemoveAt(temp.Count-1);
                    }
                }
        }
        

        private bool isPalindrome(string input, int start, int end){
            while(start < end){
                if(input[start] != input[end]){
                    return false;
                }
                start++; end--;
            }
            return true;
        }
    }
}

