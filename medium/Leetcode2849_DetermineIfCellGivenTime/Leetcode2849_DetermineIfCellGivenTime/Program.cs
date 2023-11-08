using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode2849_DetermineIfCellGivenTime
{
    public class Solution
    {
        public bool IsReachableAtTime(int sx, int sy, int fx, int fy, int t)
        {
            int x_distence = Math.Abs( fx - sx);
            int y_distence = Math.Abs( fy - sy);

            int distance = Math.Max(x_distence, y_distence);

            if (distance == 0)
                return (t > 1 || t == 0) ? true : false;

            if (t <  distance)
                return false;
            else
                return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
