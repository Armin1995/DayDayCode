using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayDayLeetCode._2003;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDayLeetCode._2003.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void SmallestMissingValueSubtreeTest()
        {
            Solution solution = new Solution();
            var result = solution.SmallestMissingValueSubtree(new int[] { -1, 2, 3, 0, 2, 4, 1 }, new int[] { 2, 3, 4, 5, 6, 7, 8 });
            Assert.IsTrue(result.SequenceEqual(new int[] { 1, 1, 1, 1, 1, 1, 1 }));
        }
    }
}