using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode7_ReverseInteger
{
    public class Solution
    {
        public int Reverse(int x)
        {
            bool isMinus = x < 0;
            if (isMinus)
                x *= -1;
            string result = x.ToString();

            string reverseStr = new string(result.Reverse().ToArray());
            int output;
            if(int.TryParse(reverseStr,out output))
            {
                if (isMinus)
                    output *= -1;
                return output;
            }
            else
            {
                return 0;
            }
        }
    }

    //public class Solution
    //{
    //    public int Reverse(int x)
    //    {
    //        return Reverse(x , (int)Math.Log10(Math.Abs(x)) + 1);
    //    }
    //    public int Reverse(int x, int deep)
    //    {
    //        if(deep <= 1)
    //        {
    //            return x;
    //        }
    //        else
    //        {
    //            return (int)((x % 10) * Math.Pow(10, deep - 1)) + Reverse(x / 10, (deep - 1)); 
    //        }
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution();
            string result = sl.Reverse(1534236469).ToString();
            Console.WriteLine(result);
            
        }
    }
}
