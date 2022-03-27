using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.BinaryTree.SubtreeOfAnotherTree
{
    class SubtreeOfAnotherTree
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
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(root);

            while (s.Count > 0)
            {
                TreeNode current = s.Pop();
                if (current.val == subRoot.val)
                {
                    if (Helper(current, subRoot))
                    {
                        return true;
                    }
                }

                if (current.left != null)
                    s.Push(current.left);

                if (current.right != null)
                    s.Push(current.right);
            }
            return false;
        }

        public bool Helper(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 != null || root2 == null && root1 != null)
                return false;
            if (root1 == null && root2 == null)
                return true;
            if (root1.val != root2.val)
                return false;

            return Helper(root1.left, root2.left) && Helper(root1.right, root2.right);
        }
    }
}
