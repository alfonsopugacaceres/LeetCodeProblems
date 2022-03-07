using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.UniValuedBinaryTree
{
    public class UniValuedBST
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
        public bool IsUnivalTree(TreeNode root)
        {
            return Helper(root, root.val);//call the recursive check
        }

        public bool Helper(TreeNode root, int target)
        {
            if (root.left == null && root.right == null)//if you are at a leaf node, check to see if the condition is satisfied and return it
                return root.val == target;
            else if (root.left == null)//if the left is null then return the current evaluation AND the recursive call to the right
                return root.val == target && Helper(root.right, target);
            else if (root.right == null)
                return root.val == target && Helper(root.left, target);//if the right is null then return the current evaluation AND the recursive call to the left
            else
                return root.val == target && Helper(root.left, target) && Helper(root.right, target);//otherwise evaluate and return the recursive call on both sides
        }
    }
}
