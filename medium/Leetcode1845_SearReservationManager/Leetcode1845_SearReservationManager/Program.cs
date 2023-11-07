using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode1845_SearReservationManager
{
    public class SeatManager
    {
        private List<int> seatNumberList;
        private List<bool> seatAvalible;
        private int nowIndex;


        public SeatManager(int n)
        {
            this.seatNumberList = new List<int>();
            this.seatAvalible = new List<bool>();
            nowIndex = 0;
            for (int i = 1; i <= n; i++)
            {
                seatNumberList.Add(i);
                seatAvalible.Add(true);
            }
        }

        public int Reserve()
        {
            for(int i = nowIndex; i<seatAvalible.Count;i++)
            {
                if(seatAvalible[i])
                {
                    seatAvalible[i] = false;
                    nowIndex++;
                    return seatNumberList[i];
                }
            }
            return 0;
        }

        public void Unreserve(int seatNumber)
        {
            if (!seatAvalible[seatNumber-1])
            {
                if(nowIndex > seatNumber - 1)
                {
                    nowIndex = seatNumber - 1;
                }
                seatAvalible[seatNumber - 1] = true;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
