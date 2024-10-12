using System;
using System.Collections;


namespace DataTypes
{

    [TestClass]
    public class StringSample
    {
        [TestMethod]
        public void StringExamples(){
            string s = "Hellow world";

            foreach(char c in s.ToArray()){
                Console.WriteLine(c);
            }

            //Java equivalent od s.CharAt(1)
            Console.WriteLine("Char at index 1: "+ s[1]);
            Console.WriteLine("Get String Length : "+ s.Length);

            String s2 = "Hello";

            Console.WriteLine("Is Equal :"+ s.Equals(s2));
        }
    }
}