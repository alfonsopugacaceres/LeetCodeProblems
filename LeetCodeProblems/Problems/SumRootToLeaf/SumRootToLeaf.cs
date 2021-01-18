using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.SumRootToLeaf
{
    //1022. Sum of Root To Leaf Binary Numbers
    public class SumRootToLeaf
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

        public int SumRootToLeafFunction(TreeNode root)
        {
            return RecursiveTraversal(root, 0);//we start with a 0 for the running sum
        }
        public int RecursiveTraversal(TreeNode root, int runningSum)
        {
            if (root == null)
                return 0;

            runningSum = runningSum << 1;//shift the running sum to the left to maintain the number
            runningSum += root.val;//add the current root val, since we are shifting recursively, the priority of the bits is maintained

            if (root.left == null && root.right == null)//if its a leaf, return the running sum
            {
                return runningSum;
            }
            else
            {
                return RecursiveTraversal(root.left, runningSum) + RecursiveTraversal(root.right, runningSum);//return the addition of left and right to accumulate the entire value
            }
        }
    }
}
