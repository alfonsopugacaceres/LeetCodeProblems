using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.ClosestBinarySearchTreeVal
{
    public class ClosestBinarySearchTreeVal
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


        public int ClosestValue(TreeNode root, double target)
        {
            return ClosestRecursiveVal(root, target);
        }

        private int ClosestRecursiveVal(TreeNode root, double target)
        {
            if(root.val == target)
            {
                return root.val;
            }
            else
            {
                if(root.left == null && root.right == null)
                {
                    return root.val;
                }
                else
                {
                    double rootDiff = Math.Abs(target - root.val);
                    double leftDiff = double.MaxValue;
                    double rightDiff = double.MaxValue;
                    if(root.left != null)
                    {
                        leftDiff = Math.Abs(target - root.left.val);
                    }
                    if (root.right != null)
                    {
                        rightDiff = Math.Abs(target - root.right.val);
                    }

                    if(rootDiff < leftDiff && rootDiff < rightDiff)
                    {
                        return root.val;
                    }
                    else if(leftDiff < rootDiff && leftDiff < rightDiff)
                    {
                        return ClosestRecursiveVal(root.left, target);
                    }
                    else
                    {
                        return ClosestRecursiveVal(root.right, target);
                    }
                }
            }
        }
    }
}
