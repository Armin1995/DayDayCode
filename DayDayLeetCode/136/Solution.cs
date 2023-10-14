using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDayLeetCode._136
{
    /// <summary>
    /// 136. 只出现一次的数字
    /// 巧妙运用异或的性质 0异或a=a a异或a=0 异或满足交换律和结合律
    /// </summary>
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int ret = 0;
            foreach (int e in nums) ret ^= e;
            return ret;
        }
    }
}
