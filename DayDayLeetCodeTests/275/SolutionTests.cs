using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayDayLeetCode._275;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDayLeetCode._275.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void HIndexTest()
        {
            Solution solution = new Solution();
            Assert.AreEqual(solution.HIndex(new int[] { 0, 1, 3, 5, 6 }), 3);
            Assert.AreEqual(solution.HIndex(new int[] { 1, 2, 100 }), 2);
            Assert.AreEqual(solution.HIndex(new int[] { 1, 1, 1, 1, 2, 100 }), 2);
        }
    }
}