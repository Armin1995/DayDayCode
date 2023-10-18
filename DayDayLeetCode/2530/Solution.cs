using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDayLeetCode._2530
{
    /// <summary>
    /// 2530. 执行 K 次操作后的最大分数
    /// </summary>
    public class Solution
    {
        public long MaxKelements(int[] nums, int k)
        {
            PriorityQueue<int, int> q = new PriorityQueue<int, int>();
            foreach (int num in nums)
            {
                q.Enqueue(num, -num);
            }
            long ans = 0;
            for (int i = 0; i < k; ++i)
            {
                int x = q.Dequeue();
                ans += x;
                q.Enqueue((x + 2) / 3, -(x + 2) / 3);
            }
            return ans;
        }
    }
}
