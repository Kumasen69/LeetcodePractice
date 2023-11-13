using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode815_BusRoutes
{
    public class Solution
    {

        List<int>[] routeMap = new List<int>[501];

        //針對routeMap做初始化
        public void initRouteMap()
        {
            for(int i = 0; i<routeMap.Length;i++)
            {
                routeMap[i] = new List<int>();
            }
        }

        public void getRouteMap(int[][] routes)
        {
            initRouteMap();
            for (int i = 0; i < routes.Length - 1;i++)
            {
                for(int j = i+1; j < routes.Length;j++)
                {
                    if(checkSamePoint(routes[i],routes[j]))
                    {
                        routeMap[i].Add(j);
                        routeMap[j].Add(i);
                    }
                }
            }
        }

        public bool checkSamePoint(int[] a, int[] b)
        {
            foreach(var i in a)
            {
                if (b.Contains(i))
                    return true;
            }
            return false;
        }


        public int NumBusesToDestination(int[][] routes, int source, int target)
        {
            if (source == target)
                return 0;
            //Start: -1

            //取得RouteMap
            getRouteMap(routes);


            HashSet<int> targetPoint = new HashSet<int>();

            HashSet<int> visited = new HashSet<int>();
            Queue<int> queue = new Queue<int>();
            Dictionary<int, int> distance = new Dictionary<int, int>();

            for (int i = 0; i < routes.Length; i++)
            {
                if (routes[i].Contains(source))
                {
                    distance.Add(i, 1);
                    queue.Enqueue(i);
                    visited.Add(i);
                }
                if (routes[i].Contains(target))
                {
                    targetPoint.Add(i);
                }
            }



            while (queue.Count > 0)
            {
                int current = queue.Dequeue();

                if (targetPoint.Contains(current))
                {
                    return distance[current];
                }

                foreach (int neighbor in routeMap[current])
                {
                    if (!visited.Contains(neighbor))
                    {
                        queue.Enqueue(neighbor);
                        visited.Add(neighbor);
                        distance[neighbor] = distance[current] + 1;
                    }
                }
            }


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
            Solution sl = new Solution();
            int[][] routes = new int[][]
            {
                new int[] {1, 2, 7},
                new int[] {3, 6, 7}
            };

            sl.NumBusesToDestination(routes, 1, 6);
        }
    }
}
