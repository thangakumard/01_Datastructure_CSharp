using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms.Arrays.Backtracking.Combination
{
    [TestClass]
    public class Combinations04_PhoneNumber
    {

       [TestMethod]
        public void Subsets()
        {
            List<string> result = GetLetterCombinations("25");
                foreach(string x in result){
                    Console.WriteLine(x);
                }
        }
        private List<string> GetLetterCombinations(string numbers) {
            List<string> result = new List<string>();

            Dictionary<int, string> dicNumber = new Dictionary<int, string>();
            dicNumber.Add(2, "abc");
            dicNumber.Add(3, "def");
            dicNumber.Add(4, "ghi");
            dicNumber.Add(5, "jkl");
            dicNumber.Add(6, "mno");
            dicNumber.Add(7, "pqrs");
            dicNumber.Add(8, "tuv");
            dicNumber.Add(9, "wxyz");

            List<string> lstInput = new List<string>();

            foreach(char c in numbers.ToCharArray()){
                lstInput.Add(dicNumber[c-'0']);
            }

            BacktrackingHelper(result, numbers, lstInput,"",0 );

            return result;
         }

         private void BacktrackingHelper(List<string> result, string numbers, List<string> lstInput, string temp, int start){
            if(temp.Length == numbers.Length){
                result.Add(temp);
                return;
            }
            if(start >= lstInput.Count) return;

                string word =  lstInput[start];
                for(int i=0; i < word.Length; i++){
                    BacktrackingHelper(result, numbers, lstInput, temp + word[i], start+1);
                }
            

         }
 
    }


}