using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode557_ReverseWordsInString
{
    public class Solution
    {
        public string ReverseWords(string s)
        {
            return string.Join(" ", s.Split(' ').ToList().ConvertAll((x) => new string(x.Reverse().ToArray())).ToArray());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
