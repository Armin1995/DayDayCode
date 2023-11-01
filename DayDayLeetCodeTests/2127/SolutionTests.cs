using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayDayLeetCode._2127;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDayLeetCode._2127.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void MaximumInvitationsTest()
        {
            Solution solution = new Solution();
            Assert.AreEqual(solution.MaximumInvitations(new int[] { 2, 2, 1, 2 }),3);
            Assert.AreEqual(solution.MaximumInvitations(new int[] { 1, 2, 0 }),3);
            Assert.AreEqual(solution.MaximumInvitations(new int[] { 3, 0, 1, 4, 1 }),4);
            Assert.AreEqual(solution.MaximumInvitations(new int[] { 1, 0, 0, 2, 1, 4, 7, 8, 9, 6, 7, 10, 8 }),6);
        }
    }
}