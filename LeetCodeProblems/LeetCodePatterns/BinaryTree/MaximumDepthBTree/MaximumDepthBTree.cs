using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.BinaryTree.MaximumDepthBTree
{
    class MaximumDepthBTree
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            Stack<(TreeNode, int)> s = new Stack<(TreeNode, int)>();
            s.Push((root, 1));
            int max = 0;

            while (s.Count > 0)
            {
                (TreeNode, int) current = s.Pop();
                max = Math.Max(max, current.Item2);

                if (current.Item1.right != null)
                    s.Push((current.Item1.right, current.Item2 + 1));
                if (current.Item1.left != null)
                    s.Push((current.Item1.left, current.Item2 + 1));
            }

            return max;
        }

        public int MaxDepth1(TreeNode root)
        {
            return Helper(0, root);
        }

        public int Helper(int num, TreeNode root)
        {
            if (root == null)
                return num;
            return Math.Max(Helper(num + 1, root.right), Helper(num + 1, root.left));
        }
    }
}
