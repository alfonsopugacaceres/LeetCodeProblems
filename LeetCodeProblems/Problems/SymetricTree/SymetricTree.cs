using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.SymetricTree
{
    public class SymetricTree
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
        public bool isMirror(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null) return true;
            if (t1 == null || t2 == null) return false;
            return (t1.val == t2.val)//check the values being the same AND
                && isMirror(t1.right, t2.left)//check the recursive call of right and left are the sale
                && isMirror(t1.left, t2.right);//check the recursive call viceversa
        }
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return false;
            else
                return Helper(root.left, root.right);//call the recursive function
        }

        public bool Helper(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)//if both nodes are null, return true
                return true;
            else if ((left == null && right != null) || (right == null && left != null))//if one nore and not the other are null return false
                return false;
            if(left.val != right.val)//if the values are not the same return false
                return false;

            return Helper(left.right, right.left) && Helper(left.left, right.right);//otherwise return the leper of one side with the other to check for 
                                                                                    //mirror like features, notice how the helper call is flipped
        }
    }
}
