using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDayLeetCode._1488
{
    /// <summary>
    /// 1488. 避免洪水泛滥
    /// </summary>
    public class Solution
    {
        public int[] AvoidFlood(int[] rains)
        {
            int[] ans = new int[rains.Length];
            Array.Fill(ans, 1);
            SortedSet<int> st = new SortedSet<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < rains.Length; i++)
            {
                if (rains[i] == 0)
                {
                    st.Add(i);
                }
                else
                {
                    ans[i] = -1;

                    if (dict.ContainsKey(rains[i]))
                    {
                        int it = st.FirstOrDefault(n => n >= dict[rains[i]], -1);
                        if (it == -1) return new int[0];
                        ans[it] = rains[i];
                        st.Remove(it);
                    }

                    dict.TryAdd(rains[i], i);
                    dict[rains[i]] = i;
                }
            }

            return ans;
        }
    }
}
