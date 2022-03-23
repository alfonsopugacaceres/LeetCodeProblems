using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.BinaryTree.DiameterOfBinaryTree
{
    class DiameterOfBinaryTree
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
        int diameter = 0;
        public int DiameterOfBinaryTree1(TreeNode root)
        {
            RecursiveLongestDiameter(root);
            return diameter;
        }

        public int RecursiveLongestDiameter(TreeNode root)
        {

            if (root == null)
                return 0;


            int LongestRightEdge = 0;
            int LongestLeftEdge = 0;

            LongestRightEdge = RecursiveLongestDiameter(root.right);
            LongestLeftEdge = RecursiveLongestDiameter(root.left);
            diameter = Math.Max(diameter, LongestRightEdge + LongestLeftEdge);

            return Math.Max(LongestRightEdge, LongestLeftEdge) + 1;


        }
    }
}
