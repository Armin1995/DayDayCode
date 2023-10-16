using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDayLeetCode._260
{
    /// <summary>
    /// 260. 只出现一次的数字 III
    /// </summary>
    public class Solution
    {
        public int[] SingleNumber(int[] nums)
        {
            int xorsum = 0;
            foreach (var num in nums)
            {
                xorsum ^= num;
            }
            // 防止溢出
            int lsb = (xorsum == int.MinValue ? xorsum : xorsum & (-xorsum));
            int type1 = 0, type2 = 0;
            foreach (int num in nums)
            {
                if ((num & lsb) != 0)
                {
                    type1 ^= num;
                }
                else
                {
                    type2 ^= num;
                }
            }
            return new int[] { type1, type2 };
        }
    }
}
