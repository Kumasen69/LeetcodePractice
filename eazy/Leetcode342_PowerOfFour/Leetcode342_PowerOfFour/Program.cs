using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode342_PowerOfFour
{
    public class Solution
    {
        public bool IsPowerOfFour(int n)
        {
            double temp = Math.Log(n, 4);
            return temp == (int)temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
