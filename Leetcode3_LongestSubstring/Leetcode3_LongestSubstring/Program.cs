using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode3_LongestSubstring
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            List<char> tempChar = new List<char>();
            int max = 0;
            foreach(char i in s)
            {
                if(tempChar.IndexOf(i)==-1)
                {
                    tempChar.Add(i);
                }
                else
                {
                    while(tempChar.IndexOf(i)!=-1)
                        tempChar.RemoveAt(0);
                    tempChar.Add(i);
                }
                if (max < tempChar.Count)
                    max = tempChar.Count;
            }

            return max;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
