using System;
using System.Collections;

namespace Strings
{

    [TestClass]
    public class IsAnagram
    {
        [TestMethod]
        public void ValidateAnagram()
        {
            Assert.AreEqual(true, IsAnagram1("anagram","nagaram"));
            Assert.AreEqual(false, IsAnagram1("rat","car"));
        }
        public bool IsAnagram1(string s, string t) {
            int[] counter = new int[26];

            foreach(char c in s){
                counter[c-'a']++;
            }

            foreach(char c in t){
                counter[c-'a']--;
            }

            for(int i=0; i < 26;i++){
                if(counter[i] != 0) return false;
            }

            return true;
        }
    }
}