using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode2642_DesignGraph
{
    public class Graph
    {

        List<int[]> edgesList = new List<int[]>();
        int nodeNum = 0;

        public Graph(int n, int[][] edges)
        {
            edgesList = edges.ToList();
            nodeNum = n;
        }

        public void AddEdge(int[] edge)
        {
            edgesList.Add(edge);
        }

        public int ShortestPath(int node1, int node2)
        {
            //距離初始化
            Dictionary<int, int> distance = new Dictionary<int, int>();
            distance[node1] = 0;


            //廣度搜尋
            Queue<int> queue = new Queue<int>();
            HashSet<int> visited = new HashSet<int>();

            queue.Enqueue(node1);

            while (queue.Count != 0)
            {
                int current = queue.Dequeue();
                visited.Add(current);

                for (int i = 0; i < edgesList.Count; i++)
                {
                    if (edgesList[i][0] == current)
                    {
                        int neighbor = edgesList[i][1];

                        if (!distance.ContainsKey(neighbor))
                        {
                            distance[neighbor] = int.MaxValue;
                        }

                        if (distance[neighbor] > distance[current] + edgesList[i][2])
                        {
                            distance[neighbor] = distance[current] + edgesList[i][2];
                        }

                        if (visited.Contains(neighbor))
                            continue;

                        queue.Enqueue(neighbor);

                    }
                }

            }

            if (!distance.ContainsKey(node2))
                return -1;
            else
                return distance[node2];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph(13, new int[][]{
    new int[] {11, 6, 84715}, new int[] {7, 9, 764823}, new int[] {6, 0, 315591}, new int[] {1, 4, 909432},
    new int[] {6, 5, 514907}, new int[] {9, 6, 105610}, new int[] {3, 10, 471042}, new int[] {7, 10, 348752},
    new int[] {5, 11, 715628}, new int[] {6, 1, 973999}, new int[] {8, 7, 593929}, new int[] {7, 6, 64688},
    new int[] {6, 4, 741734}, new int[] {10, 1, 894247}, new int[] {9, 7, 81181}, new int[] {2, 11, 75418},
    new int[] {12, 2, 85431}, new int[] {7, 2, 260306}, new int[] {11, 9, 640614}, new int[] {2, 3, 648804},
    new int[] {4, 12, 568023}, new int[] {0, 8, 730096}, new int[] {9, 11, 633474}, new int[] {3, 6, 390214},
    new int[] {1, 10, 117955}, new int[] {9, 8, 222602}, new int[] {10, 7, 689294}
});

            g.AddEdge(new int[] { 1, 2, 36450 });
            g.AddEdge(new int[] { 8, 0, 709628 });
            g.AddEdge(new int[] { 2, 4, 30185 });
            g.AddEdge(new int[] { 12, 1, 21696 });
            g.AddEdge(new int[] { 1, 8, 2553 });

            Console.WriteLine(g.ShortestPath(8, 9));
            Console.WriteLine(g.ShortestPath(1, 11));
            Console.WriteLine(g.ShortestPath(3, 4));

            g.AddEdge(new int[] { 4, 6, 2182 });
            g.AddEdge(new int[] { 7, 5, 206 });
            g.AddEdge(new int[] { 5, 7, 140 });
            Console.WriteLine(g.ShortestPath(12, 5));

            g.AddEdge(new int[] { 12, 6, 365184 });
            g.AddEdge(new int[] { 3, 2, 5 });
            Console.WriteLine(g.ShortestPath(4, 8));
            Console.WriteLine(g.ShortestPath(7, 10));
            Console.WriteLine(g.ShortestPath(0, 5));

            g.AddEdge(new int[] { 0, 11, 5 });
            g.AddEdge(new int[] { 1, 7, 5 });
            Console.WriteLine(g.ShortestPath(0, 8));

            Console.WriteLine(g.ShortestPath(11, 11));
            Console.WriteLine(g.ShortestPath(7, 4));
            Console.WriteLine(g.ShortestPath(0, 12));

            g.AddEdge(new int[] { 3, 9, 858944 });
            g.AddEdge(new int[] { 0, 9, 4 });
            Console.WriteLine(g.ShortestPath(3, 5));
            Console.WriteLine(g.ShortestPath(4, 5));
            Console.WriteLine(g.ShortestPath(12, 9));

            g.AddEdge(new int[] { 12, 9, 629052 });
            Console.WriteLine(g.ShortestPath(3, 8));
            Console.WriteLine(g.ShortestPath(4, 11));
            Console.WriteLine(g.ShortestPath(9, 6));

            g.AddEdge(new int[] { 12, 7, 4 });
            Console.WriteLine(g.ShortestPath(7, 10));
            Console.WriteLine(g.ShortestPath(2, 5));
            Console.WriteLine(g.ShortestPath(6, 11));
            Console.WriteLine(g.ShortestPath(12, 2));
            Console.WriteLine(g.ShortestPath(9, 7));

            g.AddEdge(new int[] { 4, 3, 879736 });
            Console.WriteLine(g.ShortestPath(1, 3));
            Console.WriteLine(g.ShortestPath(1, 0));
            Console.WriteLine(g.ShortestPath(4, 6));

            Console.ReadKey();
        }
    }
}
