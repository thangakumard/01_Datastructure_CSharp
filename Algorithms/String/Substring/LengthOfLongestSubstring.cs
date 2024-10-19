using System;
using System.Collections;

namespace Algorithms.String.Substring
{

//https://leetcode.com/problems/longest-substring-without-repeating-characters/

    [TestClass]
    public class LengthOfLongestSubstring
    {
        [TestMethod]
        public void LengthOfLongestSubstring01() {
            Solution("abcabcbb");
        }
       public int Solution(string s) {
        if(s == null || s.Length == 0)
            return 0;

        HashSet<char> set = new HashSet<char>();
        int result = 0;

        int left =0, right =0;

        while(right < s.Length){
            if(!set.Contains(s[right])){
                set.Add(s[right]);
                right++;
            }else{
                set.Remove(s[left]);
                left++;
            }
            result = Math.Max(result, right-left);
        }

        return result;
    }
    }
}