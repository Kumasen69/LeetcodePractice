using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode1_TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            for(int i = 0; i<nums.Length-1;i++)
                for(int j = i+1; j < nums.Length; j++)
                {
                    if(nums[i]+nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
