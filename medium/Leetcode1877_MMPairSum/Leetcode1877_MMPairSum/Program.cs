using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode1877_MMPairSum
{
    public class Solution
    {
        public int MinPairSum(int[] nums)
        {
            Array.Sort(nums);
            int largist = 0;
            for(int i = 0; i< nums.Length/2; i++)
            {
                if (nums[i] + nums[nums.Length-1-i] > largist)
                {
                    largist = nums[i] + nums[nums.Length-1-i];
                }
            }
            return largist;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
