using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://leetcode.cn/problems/split-with-minimum-sum/solutions/2470641/zui-xiao-he-fen-ge-by-leetcode-solution-6fde/
namespace DayDayLeetCode._2578
{
    public class Solution
    {
        public int SplitNum(int num)
        {
            var group = num.ToString().ToCharArray();
            Array.Sort(group);

            int num1 = 0;
            int num2 = 0;
            for (int i = 0; i < group.Length; i++)
            {
                if (i % 2 == 0)
                {
                    num1 = num1 * 10 + group[i] - '0';
                }
                else
                {
                    num2 = num2 * 10 + group[i] - '0';
                }

            }

            return num1 + num2;
        }
    }
}
