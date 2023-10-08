using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://leetcode.cn/problems/stock-price-fluctuation/solutions/1227200/c-dictionary-sorted-list-by-ding_ding_di-jacj/
namespace DayDayLeetCode._2034
{
    public class StockPrice
    {
        private Dictionary<int, int> _prices;
        private SortedList _sortedList;
        private int _lastIndex;

        public StockPrice()
        {
            this._sortedList = new SortedList();
            this._prices = new Dictionary<int, int>();
            this._lastIndex = 0;
        }

        public void Update(int timestamp, int price)
        {
            if (this._prices.ContainsKey(timestamp))
            {
                var previousValue = this._prices[timestamp];

                this.RemoveOrDeductValueFromSortedList(this._sortedList, previousValue);
            }

            this._prices[timestamp] = price;
            this._lastIndex = Math.Max(timestamp, this._lastIndex);

            this.AddValueFromSortedList(this._sortedList, price);
        }

        public int Current() => this._prices[this._lastIndex];

        public int Maximum() => (int)this._sortedList.GetKey(this._sortedList.Count - 1);

        public int Minimum() => (int)this._sortedList.GetKey(0);

        private void RemoveOrDeductValueFromSortedList(SortedList sortedList, int value)
        {
            if (sortedList.ContainsKey(value))
            {
                var index = sortedList.IndexOfKey(value);

                int remainingCountOfKey = (int)sortedList.GetByIndex(index);

                if (remainingCountOfKey == 1)
                {
                    sortedList.RemoveAt(index);
                }
                else
                {
                    sortedList.SetByIndex(index, remainingCountOfKey - 1);
                }
            }
        }

        private void AddValueFromSortedList(SortedList sortedList, int key)
        {
            if (sortedList.ContainsKey(key))
            {
                var index = sortedList.IndexOfKey(key);
                int remainingCountOfKey = (int)sortedList.GetByIndex(index);
                sortedList.SetByIndex(index, remainingCountOfKey + 1);
            }
            else
            {
                sortedList.Add(key, 1);
            }
        }
    }

}
