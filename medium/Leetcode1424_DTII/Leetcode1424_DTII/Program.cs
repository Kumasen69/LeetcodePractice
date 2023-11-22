using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode1424_DTII
{
    public class Solution
    {
        public int[] FindDiagonalOrder(IList<IList<int>> nums)
        {
            List<int> result = new List<int>();
            Dictionary<int, int> pipeLineCount = new Dictionary<int, int>();
            int maxLenghth = nums.Count;
            int width = 0;
            foreach (var i in nums)
            {
                maxLenghth = (maxLenghth < i.Count) ? i.Count : maxLenghth;
                width = (width < i.Count) ? i.Count : width;

            }
            int x, y;
            x = 0;
            y = 0;

            for(int i = 0; i< maxLenghth; i++)
            {
                x = i;
                y = 0;

                while(!(x < 0) && !(y>=maxLenghth))
                {
                    if(nums.Count > x)
                    {
                        if (nums[x].Count > y)
                            result.Add(nums[x][y]);
                    }
                    x--;
                    y++;
                    if (y > width)
                        break;
                }
            }

            for(int i = 1; i<maxLenghth;i++)
            {
                x = maxLenghth - 1;
                y = i;
                while (!(x < 0) && !(y >= maxLenghth))
                {
                    if (nums.Count > x)
                    {
                        if (nums[x].Count > y)
                            result.Add(nums[x][y]);
                    }
                    x--;
                    y++;
                    if (y > width)
                        break;
                }
            }

            //for(int i = 0; i<maxLenghth; i++)
            //{
            //    for(int j = 0; j<=i;j++)
            //    {
            //        if(nums.Count> i - j)
            //        {
            //            if(nums[i].Count>j)
            //            {
            //                result.Add(nums[i-j][j]);
            //            }
            //        }
            //    }
            //}

            //for(int i = 1; i < maxLenghth; i++)
            //{
            //    for(int j = 0; j < maxLenghth; j++)
            //    {
            //        if(nums.Count> (maxLenghth - 1) - j)
            //        {
            //            if (i + j > (maxLenghth - 1))
            //                break;
            //            if(nums[maxLenghth - i].Count > i + j)
            //            {
            //                result.Add(nums[(maxLenghth - 1) - j][j]);
            //            }
            //        }
            //    }
            //}

            return result.ToArray();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution();

            int[][] numList = new int[][]
            {
                new int[]{1,2,3 },
                new int[]{ 4,5,6},
                new int[]{ 7,8,9}
            };

            int[] a = sl.FindDiagonalOrder(numList);

            Console.WriteLine("12313");
            Console.ReadKey();
        }
    }
}
