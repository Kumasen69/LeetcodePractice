using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode2038_RemoveColoredPieces
{
    public class Solution
    {
        public bool WinnerOfGame(string colors)
        {
            int alice = 0;
            int bob = 0;

            bool prevStatus = colors[0] == 'A';
            byte temp = 0;

            for (int i = 0; i<colors.Length;i++)
            {
                if (colors[i] == 'A')
                {
                    if (!prevStatus)
                    {
                        if (temp < 3)
                            bob -= temp;
                        else
                            bob -= 2;

                        temp = 0;
                    }
                    alice++;
                    temp++;
                    prevStatus = true;
                }
                else if (colors[i] == 'B')
                {
                    if (prevStatus)
                    {
                        if (temp < 3)
                            alice -= temp;
                        else
                            alice -= 2;

                        temp = 0;
                    }
                    bob++;
                    temp++;
                    prevStatus = false;
                }
            }
            if(prevStatus)
            {
                if (temp < 3)
                    alice -= temp;
                else
                    alice -= 2;

                temp = 0;
            }
            else
            {
                if (temp < 3)
                    bob -= temp;
                else
                    bob -= 2;

                temp = 0;
            }
            GC.Collect();
            return alice > bob;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
