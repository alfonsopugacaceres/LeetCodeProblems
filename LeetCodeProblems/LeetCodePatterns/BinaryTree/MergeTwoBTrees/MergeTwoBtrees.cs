using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.MergeTwoBTrees
{
    public class MergeTwoBtrees
    {
        //617. Merge Two Binary Trees
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

        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {

            if (root1 == null && root2 == null)
                return null;
            if (root1 != null && root2 == null)
                return root1;
            if (root2 != null && root1 == null)
                return root2;

            root1.val = root1.val + root2.val;
            TreeNode left = null;
            TreeNode right = null;
            left = MergeTrees(root1.left, root2.left);
            right = MergeTrees(root1.right, root2.right);

            root1.left = left;
            root1.right = right;

            (TreeNode, int) x = null;
            x.v
            return root1;

        }

    }
}
