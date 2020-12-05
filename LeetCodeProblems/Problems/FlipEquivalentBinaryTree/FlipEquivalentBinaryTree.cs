using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.FlipEquivalentBinaryTree
{
    public class FlipEquivalentBinaryTree
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
        public bool flipEquiv(TreeNode root1, TreeNode root2)
        {
            if (root1 == root2)
                return true;
            if (root1 == null || root2 == null || root1.val != root2.val)
                return false;

            return (flipEquiv(root1.left, root2.left) && flipEquiv(root1.right, root2.right) ||
                    flipEquiv(root1.left, root2.right) && flipEquiv(root1.right, root2.left));
        }

    }
}
