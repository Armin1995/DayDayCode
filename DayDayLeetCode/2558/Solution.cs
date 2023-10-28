using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDayLeetCode._2558
{
    /// <summary>
    /// 2558. 从数量最多的堆取走礼物
    /// </summary>
    public class Solution
    {
        public long PickGifts(int[] gifts, int k)
        {
            PriorityQueue<int, int> sortedList = new PriorityQueue<int, int>();
            for (int i = 0; i < gifts.Length; i++)
            {
                sortedList.Enqueue(gifts[i], -gifts[i]);
            }

            for (int i = 0; i < k; i++)
            {
                var value = sortedList.Dequeue();

                value = (int)Math.Floor(Math.Sqrt(value));
                sortedList.Enqueue(value, -value);
            }

            long sum = 0;
            while (sortedList.Count > 0)
            {
                sum += sortedList.Dequeue();
            }

            return sum;
        }
    }
}
