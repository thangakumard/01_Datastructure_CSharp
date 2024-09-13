using System;
using System.Collections;

namespace Collections
{

    [TestClass]
    public class DictionarySample
    {
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