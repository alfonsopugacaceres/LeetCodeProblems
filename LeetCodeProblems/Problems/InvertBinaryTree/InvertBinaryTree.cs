using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.InvertBinaryTree
{
    //226. Invert Binary Tree
    public class InvertBinaryTree
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

        public TreeNode InvertTree(TreeNode root)//use a recursive function
        {
            if (root == null)//if we are at a leaf, return null
                return null;
            else
            {
                TreeNode left = InvertTree(root.left);//call the invert function on the left
                TreeNode right = InvertTree(root.right);//call the invert function on the right
                root.right = left;//swap root right with left
                root.left = right;//swap root left with right
                return root;//return the root
            }
        }

    }
}
