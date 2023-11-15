using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode1846_MaximumElement
{

    public class Solution
    {
        public int MaximumElementAfterDecrementingAndRearranging(int[] arr)
        {
            Array.Sort(arr);

            int nextNum = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>=nextNum)
                {
                    nextNum++;
                }
            }

            return nextNum-1;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution();
            int[] x = { 2,2,1,2,1 };

            Console.WriteLine(sl.MaximumElementAfterDecrementingAndRearranging(x).ToString());
            Console.ReadKey();

        }
    }
}
