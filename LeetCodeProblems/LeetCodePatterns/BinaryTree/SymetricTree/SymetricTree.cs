using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.BinaryTree.SymetricTree
{
    class SymetricTree
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
        public bool IsSymmetric(TreeNode root)
        {
            return helper(root.left, root.right);
        }

        public bool helper(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null)//if they are both null, return true
                return true;
            else if (root1 == null && root2 != null || root2 == null && root1 != null)//if one is null and the other isnt return false
                return false;
            else if (root1.val != root2.val)//if the values are mismatched return false
                return false;
            else//since the values are symetric we are mirrored down the middle, the left hand side and the right hand side are mirrored in the trees
                return helper(root1.left, root2.right) && helper(root1.right, root2.left);//therefore compare the left to the right and vice versa
        }
    }
}
