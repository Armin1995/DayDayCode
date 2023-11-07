using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDayLeetCode._2586
{
    public class Solution
    {
        public int VowelStrings(string[] words, int left, int right)
        {
            int count = 0;

            for (int i = left; i <= right; i++)
            {
                if ((words[i][0] == 'a' || words[i][0] == 'e' || words[i][0] == 'i' || words[i][0] == 'o' || words[i][0] == 'u') && (words[i][words[i].Length-1] == 'a' || words[i][words[i].Length - 1] == 'e' || words[i][words[i].Length - 1] == 'i' || words[i][words[i].Length - 1] == 'o' || words[i][words[i].Length - 1] == 'u'))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
