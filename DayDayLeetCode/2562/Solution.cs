using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDayLeetCode._2562
{
    /// <summary>
    /// 2562. 找出数组的串联值
    /// </summary>
    public class Solution
    {
        public long FindTheArrayConcVal(int[] nums)
        {
            var result = 0l;

            for (int i = 0; i < nums.Length / 2; i++)
            {
                result += long.Parse($"{nums[i]}{nums[nums.Length - 1 - i]}");
            }

            if (nums.Length % 2 == 1)
            {
                result += nums[nums.Length / 2];
            }

            return result;
        }
    }
}
