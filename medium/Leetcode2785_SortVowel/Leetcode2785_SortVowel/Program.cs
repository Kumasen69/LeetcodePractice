using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode2785_SortVowel
{
    public class Solution
    {
        public string SortVowels(string s)
        {
            char[] vowelArray = { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };

            List<char> vowelList = new List<char>();
            List<int> indexList = new List<int>();


            for (int i = 0; i < s.Length; i++)
            {
                if (vowelArray.Contains(s[i]))
                {
                    vowelList.Add(s[i]);
                    indexList.Add(i);
                }
            }
            vowelList.Sort();

            char[] result = s.ToCharArray();
            for (int i = 0; i < vowelList.Count; i++)
            {
                
                result[indexList[i]] = vowelList[i];
            }

            return new string(result);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution();
            sl.SortVowels("abc");
        }
    }
}
