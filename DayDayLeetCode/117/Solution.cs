using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DayDayLeetCode._117
{
    public class Solution
    {
        public Node Connect(Node root)
        {
            if (root == null)
            {
                return root;
            }

            var nodes = new Queue<Node>();
            nodes.Enqueue(root);

            while (nodes.Count > 0)
            {
                var count = nodes.Count;
                Node pre = null;

                for (int i = 0; i < count; i++)
                {
                    var node = nodes.Dequeue();

                    if (pre != null)
                    {
                        pre.next = node;
                    }

                    pre = node;

                    if (node.left != null)
                    {
                        nodes.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        nodes.Enqueue(node.right);
                    }
                }
            }

            return root;
        }
    }

    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
}
