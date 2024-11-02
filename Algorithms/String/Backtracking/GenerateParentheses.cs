
/****
 * https://leetcode.com/problems/generate-parentheses/ Given n pairs of
 * parentheses, write a function to generate all combinations of well-formed
 * parentheses.
 * 
 *
 * Example 1:
 * 
 * Input: n = 3 Output: ["((()))","(()())","(())()","()(())","()()()"] Example
 * 2:
 * 
 * Input: n = 1 Output: ["()"]
 * 
 * 
 * Constraints:
 * 
 * 1 <= n <= 8
 *
 */
 
/*
 Time: O(2 ^ N) 
 Sapce: O(N)
*/
namespace Algorithms.String.Backtracking
{
    [TestClass]
    public class GenerateParentheses
    {
        [TestMethod]
        public void TestGenerateParentheses(){
            int length = 3;
            List<string> result =  GetParantheses(length);
            foreach(string s in result){
                Console.WriteLine(s);
            }
        }

        private List<string> GetParantheses(int length){
            List<string> result = new List<string>();
            backTracking(result, "", 0, 0 ,length);
            return result;
        } 

        private void backTracking(List<string> result, string current, int open, int close,int max){
            if(current.Length == max * 2){
                result.Add(current);
                return;
            }else{
                if(open < max)
                    backTracking(result, current + "(", open+1, close, max);
                if(close < open)
                    backTracking(result, current + ")", open, close+1, max);
            }
        }
    }
}