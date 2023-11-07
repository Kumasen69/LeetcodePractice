using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode1356_SortIntBit
{
    public class Solution
    {
        public int GetBitOne(int input)
        {
            if(input <= 1)
            {
                return input;
            }
            else
            {
                return GetBitOne(input / 2) + input % 2; 
            }
        }

        public int[] SortByBits(int[] arr)
        {
            Dictionary<int, List<int>> result = new Dictionary<int, List<int>>();


            int[] arr_bit = new int[arr.Length];



            for(int i =0;i<arr.Length;i++)
            {
                arr_bit[i] = GetBitOne(arr[i]);
            }
            Array.Sort(arr, arr_bit);
           
            for(int i =0;i<arr.Length;i++)
            {
                if(result.TryGetValue(arr_bit[i],out List<int> output))
                {
                    result[arr_bit[i]].Add(arr[i]);
                }
                else
                {
                    result[arr_bit[i]] = new List<int>();
                    result[arr_bit[i]].Add(arr[i]);
                }
            }

            int[] outputArr = new int[0];

            Array.Sort(arr_bit);
            int prevIndex = -1;

            foreach(int i in arr_bit)
            {
                if (prevIndex == i)
                    continue;
                if (result.TryGetValue(i, out List<int> output))
                {
                    prevIndex = i;
                    outputArr = outputArr.Concat(result[i].ToArray()).ToArray();
                }
                else
                {
                    continue;
                }
            }

            return outputArr;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 7850, 8192, 1878, 2687, 6878, 7410, 763, 365, 9869, 8744, 2741, 4871, 5844, 2715, 3335, 9651, 6677 };

            Solution st = new Solution();

            int[] output = st.SortByBits(a);

        }
    }
}
