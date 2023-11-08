using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayDayLeetCode._2609;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDayLeetCode._2609.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void FindTheLongestBalancedSubstringTest()
        {
            Solution solution = new Solution();
            Assert.AreEqual(solution.FindTheLongestBalancedSubstring("01000111"), 6);
            Assert.AreEqual(solution.FindTheLongestBalancedSubstring("00111"), 4);
            Assert.AreEqual(solution.FindTheLongestBalancedSubstring("111"), 0);
        }
    }
}