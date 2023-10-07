using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://leetcode.cn/problems/online-stock-span/solutions/1906765/gu-piao-jie-ge-kua-du-by-leetcode-soluti-5cm7/
namespace DayDayLeetCode._901
{
    public class StockSpanner
    {
        private Stack<Tuple<int, int>> stack;
        private int idx;

        public StockSpanner()
        {
            stack = new Stack<Tuple<int, int>>();
            stack.Push(new Tuple<int, int>(-1, int.MaxValue));
            idx = -1;
        }

        public int Next(int price)
        {
            idx++;
            while (price >= stack.Peek().Item2)
            {
                stack.Pop();
            }
            int ret = idx - stack.Peek().Item1;
            stack.Push(new Tuple<int, int>(idx, price));
            return ret;
        }
    }
}
