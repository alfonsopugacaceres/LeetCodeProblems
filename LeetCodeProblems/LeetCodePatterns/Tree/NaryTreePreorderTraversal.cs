using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Tree
{
    class NaryTreePreorderTraversal
    {
        //589. N-ary Tree Preorder Traversal
        //Given the root of an n-ary tree, return the preorder traversal of its nodes' values.
        //Nary-Tree input serialization is represented in their level order traversal.Each group of children is separated by the null value (See examples)
        public class Node
        {
            public int val;
            public IList<Node> children;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }

        public IList<int> Preorder(Node root)
        {
            IList<int> preorderTraversal = new List<int>();
            Helper(root, preorderTraversal);
            return preorderTraversal;
        }

        public void Helper(Node root, IList<int> list)
        {
            if (root == null)
                return;
            list.Add(root.val);
            foreach (Node child in root.children)
                Helper(child, list);
            return;
        }
    }
}
