using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode815_BusRoutes
{
    public class Solution
    {

        public void GetRouteMap(int[][] routes, int source, int target, Dictionary<int, int> routeMap)
        {
            
        }

        public int NumBusesToDestination(int[][] routes, int source, int target)
        {
            if (source == target)
                return 0;
            //Start: -1
            Dictionary<int, int> routeMap = new Dictionary<int, int>();

            //List<int> exceptBus = new List<int>();
            //bool containsExist = false;
            //int deep = 1;

            //while (exceptBus.Count != routes.Length && containsExist)
            //{
            //    for (int i = 0; i < routes.Length; i++)
            //    {
            //        if (exceptBus.Contains(i))
            //            continue;
            //        if (routes[i].Contains(source))
            //        {
            //            if (routes[i].Contains(target))
            //                return deep;
            //            containsExist = true;
            //            exceptBus.Add(i);
            //            routeMap.Add(-1, i);
            //        }
            //    }
            //    deep++;
            //}


            return -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
