using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode1441_StackArray
{
    public class Solution
    {
        public IList<string> BuildArray(int[] target, int n)
        {
            IList<string> result = new List<string>();

            int max_index = target.Length;
            int index = 0;

            for(int i = 1; i <= n; i++)
            {
                if(target[index] == i)
                {
                    index++;
                    result.Add("Push");
                }
                else if(target[index] > i)
                {
                    result.Add("Push");
                    result.Add("Pop");
                }
                
                if(index == max_index)
                {
                    break;
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
