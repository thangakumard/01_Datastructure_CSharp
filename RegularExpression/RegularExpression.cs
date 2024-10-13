using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Strings.RegularExpression
{

//https://leetcode.com/problems/longest-substring-without-repeating-characters/

    [TestClass]
    public class RegularExpression
    {
        [TestMethod]
        public void String_RemoveWhiteSpace() {
            String S = "I am a hero";
            String expected = "Iamahero";
            //remove all the whitespace
            var result = Regex.Replace(S, @"\s+", "");
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void String_RemoveSpacechar() {
            String S = "I_ am@ a @$#$%$her(o";
            String expected = "I am a hero";
            //remove all the spacial char except space
            var result = Regex.Replace(S, @"[^a-zA-Z ]", "");
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void String_RemoveSpacecharAllowSpace() {
            String S = "I_ am@ a @$#$%$          her(o";
            String expected = "I am a hero";
            
             // Step 1: Remove all special characters except space
            string withoutSpecialChars = Regex.Replace(S, @"[^a-zA-Z0-9\s]", "");

             // Step 2: Replace multiple spaces with a single space
            string result = Regex.Replace(withoutSpecialChars, @"\s+", " ").Trim();
            Assert.AreEqual(expected, result);
        }
    }
}