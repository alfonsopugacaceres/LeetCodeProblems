using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.CloneGraph
{
    class CloneGraph
    {
        public class Node
        {
            public int val;
            public IList<Node> neighbors;

            public Node()
            {
                val = 0;
                neighbors = new List<Node>();
            }

            public Node(int _val)
            {
                val = _val;
                neighbors = new List<Node>();
            }

            public Node(int _val, List<Node> _neighbors)
            {
                val = _val;
                neighbors = _neighbors;
            }
        }

        public Node CloneGraph1(Node node)
        {
            IDictionary<int, Node> memo = new Dictionary<int, Node>();
            return CloneGraphHelper(node, memo);

        }

        public Node CloneGraphHelper(Node node, IDictionary<int, Node> memo)
        {

            if (node == null)
                return null;
            if (memo.ContainsKey(node.val))
                return memo[node.val];

            Node newNode = new Node(node.val);
            memo.Add(newNode.val, newNode);

            foreach (Node n in node.neighbors)
            {
                Node newNeighbor = CloneGraphHelper(n, memo);
                newNode.neighbors.Add(newNeighbor);
            }

            return newNode;
        }
    }
}
