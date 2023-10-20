using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDayLeetCode._2525
{
    /// <summary>
    /// 2525. 根据规则将箱子分类
    /// </summary>
    public class Solution
    {
        public string CategorizeBox(int length, int width, int height, int mass)
        {
            long v = 1L * length * width * height;
            bool isBulky = length >= 10000 || width >= 10000 || height >= 10000 || v >= 1000000000L;
            bool isHeavy = mass >= 100;

            if (isBulky && isHeavy)
            {
                return "Both";
            }
            else if (isBulky)
            {
                return "Bulky";
            }
            else if (isHeavy)
            {
                return "Heavy";
            }
            else
            {
                return "Neither";
            }
        }
    }
}
