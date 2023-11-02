using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDayLeetCode._2103
{
    /// <summary>
    /// 2103. 环和杆
    /// </summary>
    public class Solution
    {
        public int CountPoints(string rings)
        {
            int[,] array = new int[10, 3];

            for (int i = 0; i < rings.Length; i += 2)
            {
                if (rings[i] == 'R')
                {
                    array[rings[i + 1] - '0', 0] = 1;
                }
                else if (rings[i] == 'G')
                {
                    array[rings[i + 1] - '0', 1] = 1;
                }
                else
                {
                    array[rings[i + 1] - '0', 2] = 1;
                }
            }

            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                if (array[i, 0] == 1 && array[i, 1] == 1 && array[i, 2] == 1)
                {
                    sum++;
                }
            }

            return sum;
        }
    }
}
