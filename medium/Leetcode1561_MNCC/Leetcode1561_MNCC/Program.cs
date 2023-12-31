﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode1561_MNCC
{
    public class Solution
    {
        public int MaxCoins(int[] piles)
        {
            Array.Sort(piles);
            int sum = 0;
            for(int i = piles.Length - 2; i >= piles.Length / 3; i -= 2)
            {
                sum += piles[i];
            }
            return sum; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
