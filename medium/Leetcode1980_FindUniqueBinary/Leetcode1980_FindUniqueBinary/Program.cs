using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode1980_FindUniqueBinary
{
    public class Solution
    {

        public string DecToString(int input, int n)
        {
            string result = "";
            while(input > 0)
            {
                result += (input % 2).ToString();
                input /= 2;
            }

            while(result.Length < n)
            {
                result += '0';
            }
            return new string(result.Reverse().ToArray());
        }

        public int StringToDex(string input)
        {
            int result = 0;
            int k = 1;

            string inputRev = new string(input.Reverse().ToArray());

            foreach(var i in inputRev)
            {
                result += k * int.Parse(i.ToString());
                k *= 2;
            }

            return result;
        }

        public string FindDifferentBinaryString(string[] nums)
        {
            HashSet<int> hashInt = new HashSet<int>();

            foreach(var i in nums)
            {
                hashInt.Add(StringToDex(i));
            }

            double range = Math.Pow(2, nums.Length);

            for (int i = 0; i< range; i++)
            {
                if(!hashInt.Contains(i))
                    return DecToString(i, nums.Length);
            }

            return "";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.DecToString(12,5));
            Console.WriteLine(solution.StringToDex("11111"));
            Console.ReadKey();
        }
    }
}
