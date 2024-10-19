using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructureMSTest.Algorithms.String
{
    /**
     * https://leetcode.com/problems/group-anagrams/editorial/
     */
    internal class GroupAnagram
    {

        public IList<IList<string>> GroupAnagrams(string[] input)
        {
            if (input == null || input.Length == 0)
                return new List<IList<string>>();

            Dictionary<string, List<string>> dicAnagram = new Dictionary<string, List<string>>();

            foreach (string s in input)
            {
                char[] chars = s.ToLower().ToCharArray();
                Array.Sort(chars);
                string x = new string(chars);
                if (!dicAnagram.ContainsKey(x))
                {
                    dicAnagram[x] = new List<string>();
                }
                dicAnagram[x].Add(s);
            }

            return new List<IList<string>>(dicAnagram.Values);
        }
    }
}
