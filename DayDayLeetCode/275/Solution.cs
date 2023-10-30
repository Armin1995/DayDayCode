using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDayLeetCode._275
{
    /// <summary>
    /// 275. H 指数 II
    /// </summary>
    public class Solution
    {
        public int HIndex(int[] citations)
        {
            int n = citations.Length;
            int left = 0, right = n - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (citations[mid] >= n - mid)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return n - left;
        }
    }
}
