using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode1930_UniqueL3Palidromic
{
    public class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class Solution
    {
        public int CountPalindromicSubsequence(string s)
        {
            Dictionary<char, Point> countCharRange = new Dictionary<char, Point>();

            for(int i =0;i<s.Length;i++)
            {
                if (countCharRange.ContainsKey(s[i]))
                    countCharRange[s[i]].y = i;
                else
                    countCharRange[s[i]] = new Point(i, -1);
            }

            int total = 0;

            foreach(var charRange in countCharRange)
            {
                if (charRange.Value.y == -1)
                    continue;
                else
                {
                    string subString = s.Substring(charRange.Value.x, charRange.Value.y - charRange.Value.x + 1);
                    Dictionary<char, int> countChar = new Dictionary<char, int>();

                    foreach (char c in subString)
                    {
                        if (countChar.ContainsKey(c))
                            countChar[c]++;
                        else
                            countChar[c] = 1;
                    }
                    if (countChar[charRange.Key] > 2)
                        total += countChar.Count;
                    else if (countChar[charRange.Key] == 2)
                        total += countChar.Count - 1;
                }
            }
            //Dictionary<char, int> countChar = new Dictionary<char, int>();
            
            //foreach(char c in s)
            //{
            //    if (countChar.ContainsKey(c))
            //        countChar[c]++;
            //    else
            //        countChar[c] = 1;
            //}

            //foreach(var p in countChar)
            //{
            //    if (p.Value > 2)
            //        total += countChar.Count;
            //    else if (p.Value == 2)
            //        total += countChar.Count - 1;

            //}

            return total;
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution();
            Console.WriteLine(sl.CountPalindromicSubsequence("bbcbaba"));
            Console.ReadKey();
        }
    }
}
