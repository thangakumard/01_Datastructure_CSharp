
using System;
using System.Collections;

namespace Collections.Generic
{

    [TestClass]
    public class Generic_Dictionary
    {
        [TestMethod]
        public void DictionaryKeyasString(){
            Dictionary<string, int> dictSample = new Dictionary<string, int>();
            dictSample["a"] = 10;
            Console.WriteLine("a value is :" + dictSample["a"]);

            int val = dictSample.ContainsKey("b") ? dictSample["b"] : -1;
            Console.WriteLine("b value is :" + val);

            dictSample["a"]--;
            Console.WriteLine("Decrement a value :" + dictSample["a"]);
        }

        [TestMethod]
        public void MyArrayList()
        {
            Dictionary<int, string> disctPaylerScore = new Dictionary<int, string>();
            disctPaylerScore.Add(10, "Payer_1");
            disctPaylerScore.Add(30, "Payer_2");
            disctPaylerScore.Add(40, "Payer_2");

            //To update
            disctPaylerScore[10] = "payler_10";

            if (disctPaylerScore.ContainsKey(10))
            {
               //To update
                disctPaylerScore[10] = "payler_100";
            }

            //To get value: Option 1
            string player = disctPaylerScore[10];

            //To get value: Option 2
            string result = "";
            if(disctPaylerScore.TryGetValue(30, out result)){
                Console.WriteLine("Player name is: "+ result);
            }

            disctPaylerScore.Remove(40);         
        }
    }
}