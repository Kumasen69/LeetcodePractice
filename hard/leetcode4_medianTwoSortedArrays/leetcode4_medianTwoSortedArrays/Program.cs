using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode4_medianTwoSortedArrays
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int index = 0;
            int targetIndex = nums1.Length + nums2.Length;
            List<int> intList = new List<int>();
            bool isMidIndex = (targetIndex % 2 == 1) ? true : false;
            double result = 0;
            targetIndex /= 2;
            int i = 0;
            int j = 0;



            while(i + j != targetIndex+1)
            {
                if(i == nums1.Length)
                {
                    while(j != nums2.Length)
                    {
                        intList.Add(nums2[j]);
                        j++;
                        if (intList.Count == targetIndex + 1)
                        {
                            if (isMidIndex)
                            {
                                result = intList[targetIndex];
                                return result;
                            }
                            else
                            {
                                result = intList[targetIndex] + intList[targetIndex - 1];
                                result /= 2.0;
                                return result;
                            }
                        }
                    }
                    break;
                }
                if(j == nums2.Length)
                {
                    while (i != nums1.Length)
                    {
                        intList.Add(nums1[i]);
                        i++;
                        if (intList.Count == targetIndex + 1)
                        {
                            if (isMidIndex)
                            {
                                result = intList[targetIndex];
                                return result;
                            }
                            else
                            {
                                result = intList[targetIndex] + intList[targetIndex - 1];
                                result /= 2.0;
                                return result;
                            }
                        }
                    }
                    break;
                }
                
                if(nums1[i] < nums2[j])
                {
                    intList.Add(nums1[i]);
                    i++;
                }
                else
                {
                    intList.Add(nums2[j]);
                    j++;
                }

                if(intList.Count == targetIndex+1)
                {
                    if(isMidIndex)
                    {
                        result = intList[targetIndex];
                        return result;
                    }
                    else
                    {
                        result = intList[targetIndex] + intList[targetIndex - 1];
                        result /= 2.0;
                        return result;
                    }
                }

            }

            return result;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution st = new Solution();
            int[] a = { 1, 2 };
            int[] b = { 3, 4 };

            double result = st.FindMedianSortedArrays(a, b);
            Console.WriteLine(result.ToString());
        }
    }
}
