using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayDayLeetCode._117;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDayLeetCode._117.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void ConnectTest()
        {
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node7 = new Node(7);
            Node node2 = new Node(2, node4, node5, null);
            Node node3 = new Node(3, null, node7, null);
            Node node1 = new Node(1, node2, node3, null);

            Solution solution = new Solution();
            var node = solution.Connect(node1);
        }
    }
}