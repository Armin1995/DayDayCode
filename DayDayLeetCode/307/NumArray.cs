using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDayLeetCode._307
{
    public class NumArray
    {
        private int[] nums;

        public NumArray(int[] nums)
        {
            this.nums = nums;
        }

        public void Update(int index, int val)
        {
            nums[index] = val;
        }

        public int SumRange(int left, int right)
        {
            int sum = 0;

            for (int i = left; i <= right; i++)
            {
                sum += nums[i];
            }

            return sum;
        }
    }
}
