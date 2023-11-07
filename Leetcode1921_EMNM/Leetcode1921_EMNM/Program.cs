using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode1921_EMNM
{
    public class Solution
    {

        public int EliminateMaximum(int[] dist, int[] speed)
        {
            int count = 0;
            int countOneTurn = 0;
            int nextIndex = -1;
            float minScore = 9999;
            while (true)
            {
                nextIndex = -1;
                countOneTurn = 0;
                minScore = 9999;
                for (int i = 0; i < dist.Length; i++)
                {
                    if (dist[i] <= 0)
                    {
                        continue;
                    }

                    float score = (float)dist[i] / (float)speed[i];
                    if (minScore > score && score > 0)
                    {
                        minScore = score;
                        nextIndex = i;
                    }
                    if (score > 0 && score < 1)
                    {
                        countOneTurn++;
                        if (countOneTurn > 1)
                        {
                            count++;
                            return count;
                        }
                    }
                }
                if (nextIndex == -1)
                {
                    return count;
                }

                dist[nextIndex] = -1;
                count++;
                for (int i = 0; i < dist.Length; i++)
                {
                    dist[i] -= speed[i];
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution();
            int[] dist = { 1, 3, 4 };
            int[] speed = { 1, 1, 1 };

            int result = sl.EliminateMaximum(dist, speed);
        }
    }
}
