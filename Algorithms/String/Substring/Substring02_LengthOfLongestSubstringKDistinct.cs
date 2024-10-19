using System;
using System.Collections;

namespace Algorithms.String.Substring
{

// https://leetcode.com/problems/longest-substring-with-at-most-k-distinct-characters/


    [TestClass]
    public class Substring02_LengthOfLongestSubstringKDistinct
    {
        [TestMethod]
        public void LengthOfLongestSubstringTwoDistinctChar() {
            string input = "ccaabbb";
            int result = GetLengthOfLongestSubstringTwoDistinctChar_usingCounter(input, 2);
            Assert.AreEqual(5,result);
        }

         private int GetLengthOfLongestSubstringTwoDistinctChar_usingCounter(string input, int k){
            int[] counter = new int[126];
            int left =0, right =0, distinctChar = 0, maxLength = 0;
            while(right < input.Length){
                if(counter[input[right]] == 0){
                    distinctChar++;
                }
                counter[input[right]]++;
                right++;
                while(distinctChar > k){
                    if(counter[input[left]] == 1){
                        distinctChar--;
                    }
                    counter[input[left]]--;
                    left++;
                }
                maxLength = Math.Max(maxLength, right-left);
            }
            return maxLength;
         }

        private int GetLengthOfLongestSubstringTwoDistinctChar_usingHashSet(string input){
            HashSet<Char> set = new HashSet<char>();
            int left = 0, right =0, maxLength = 0;

            while(right < input.Length){
                if(!set.Contains(input[right])){
                     set.Add(input[right]);
                }
                if(set.Count > 2){
                    set.Remove(input[left]);
                    left++;
                }else{
                    maxLength = Math.Max(maxLength, right-left);
                    right++;
                }

            }
            return maxLength;
        }
    }
}