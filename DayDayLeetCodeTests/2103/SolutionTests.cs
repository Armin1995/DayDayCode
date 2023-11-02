using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayDayLeetCode._2103;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDayLeetCode._2103.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void CountPointsTest()
        {
            Solution solution = new Solution();
            Assert.AreEqual(solution.CountPoints("B0B6G0R6R0R6G9"),1);
            Assert.AreEqual(solution.CountPoints("B0R0G0R9R0B0G0"),1);
        }
    }
}