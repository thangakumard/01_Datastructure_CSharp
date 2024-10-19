using System;
using System.Collections;

namespace Algorithms.String.Substring
{

    [TestClass]
    public class MyAtoi
    {
        [TestMethod]
        public void TestAtoi()
        {
            string s = "    -042";
            Assert.AreEqual(-42, CheckAtoi(s));
        }

        public int CheckAtoi(string s) {
            s = s.Trim();
            if(s.Length == 0)
                return 0;

            int left = 0, isNegative = 1, result = 0;

            if(s[left] == '-' || s[left] == '+'){
                if(s[left] == '-'){
                    isNegative = -1;
                }
                left++;
            }

            while(left < s.Length && char.IsNumber(s[left])){
                int digit = s[left] - '0';

                if( result > (Int32.MaxValue - digit)/10){
                    return isNegative == 1 ? Int32.MaxValue : Int32.MinValue;
                }
    
                result = (result * 10) + s[left] - '0';
                left++;
            }

            return isNegative * result;
    }
    }
}