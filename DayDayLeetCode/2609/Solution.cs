using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDayLeetCode._2609
{
    /// <summary>
    /// 2609. 最长平衡子字符串
    /// </summary>
    public class Solution
    {
        public int FindTheLongestBalancedSubstring(string s)
        {
            int zeroCount = 0;
            int oneCount = 0;

            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '0')
                {
                    if (oneCount == 0)
                    {
                        zeroCount++;
                    }
                    else
                    {
                        count = Math.Max(count, Math.Min(zeroCount, oneCount));
                        zeroCount = 1;
                        oneCount = 0;
                    }
                }
                else
                {
                    oneCount++;
                }
            }

            count = Math.Max(count, Math.Min(zeroCount, oneCount));

            return count * 2;
        }
    }
}
