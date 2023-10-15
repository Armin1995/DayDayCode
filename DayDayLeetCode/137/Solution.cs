using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDayLeetCode._137
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int ones = 0, twos = 0;
            foreach (int num in nums)
            {
                ones = ones ^ num & ~twos;
                twos = twos ^ num & ~ones;
            }
            return ones;
        }
    }
}
