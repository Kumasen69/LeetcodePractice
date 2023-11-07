using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode27_RemoveElement
{
    public class Solution
    {
        public void Swap(int[] nums, int start, int end)
        {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
        }

        public int RemoveElement(int[] nums, int val)
        {
            int endIndex = 0;
            for(int i = 0; i<nums.Length - endIndex ;i++)
            {
                if(nums[i] == val)
                {
                    endIndex++;
                    if (nums.Length - endIndex == i)
                    {
                        return nums.Length - endIndex;
                    }
                    while (nums[nums.Length - endIndex] == val)
                    {
                        endIndex++;
                        if(nums.Length - endIndex == i)
                        {
                            return nums.Length - endIndex;
                        }
                    }
                    
                    Swap(nums, i, nums.Length - endIndex);
                }
            }
            return  nums.Length - endIndex;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution();

            int[] nums = {1};
            sl.RemoveElement(nums, 1);
        }
    }
}
