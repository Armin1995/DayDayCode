using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayDayLeetCode._2558;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDayLeetCode._2558.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void PickGiftsTest()
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.PickGifts(new int[] { 25, 64, 9, 4, 100 }, 4));
        }
    }
}