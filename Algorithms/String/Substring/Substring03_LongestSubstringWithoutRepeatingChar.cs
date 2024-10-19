using System;
using System.Collections;

namespace Algorithms.String.Substring
{

// https://leetcode.com/problems/longest-substring-without-repeating-characters/description/

    [TestClass]
    public class Substring03_LongestSubstringWithoutRepeatingChar
    {
        [TestMethod]
        public void LongestSubstringWithoutRepeatingChar() {
            string input = "ccaabbb";
            int result = GetLongestSubstringWithoutRepeatingChar_usingCounter(input);
            Assert.AreEqual(2,result);
        }

         private int GetLongestSubstringWithoutRepeatingChar_usingCounter(string input){
            int[] counter = new int[126];
            int left =0, right =0, maxLength = 0;
            while(right < input.Length){
                if(counter[input[right]] == 0){
                    counter[input[right]]++;
                    right++;
                }else{
                    counter[input[left]]--;
                    left++;
                }
                maxLength = Math.Max(maxLength, right-left);
            }
            return maxLength;
         }

    }
}