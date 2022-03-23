using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GoogleRecommended.GooglePatterns.invertBinaryTree
{
    class InvertBinaryTree
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
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;
            else
            {
                TreeNode left = InvertTree(root.left);
                TreeNode right = InvertTree(root.right);
                root.right = left;
                root.left = right;
                return root;
            }
        }
}
