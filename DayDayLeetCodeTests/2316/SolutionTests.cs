using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayDayLeetCode._2316;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDayLeetCode._2316.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void CountPairsTest()
        {
            Solution solution = new Solution();
            if (solution.CountPairs(3, new int[][] { new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 1, 2 } }) != 0)
            {
                Assert.Fail();
            }
        }
    }
}