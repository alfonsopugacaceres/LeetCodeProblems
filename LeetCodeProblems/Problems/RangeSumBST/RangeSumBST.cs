using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.RangeSumBST
{
    //938. Range Sum of BST
    public class RangeSumBST
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
        public int RangeSumBST1(TreeNode root, int low, int high)
        {
            int sum = 0;
            if (root == null)//if the root is null, we return 0
                return 0;
            if (root.val >= low && root.val <= high)//if the value is between the two ranges (inclusive) add it to the sum
                sum += root.val;
            if (low < root.val)//if the rootval is larger than the min, recursively add the left node to the sum
                sum += RangeSumBST1(root.left, low, high);
            if (root.val < high)//if the rootval is smaller than the max, recursively add the right node to the sum
                sum += RangeSumBST1(root.right, low, high);

            return sum;//return the sum
        }

        public int RangeSumBST2(TreeNode root, int low, int high)
        {
            if (root == null)
                return 0;
            if (root.val < low)
                return RangeSumBST2(root.right, low, high);
            if (root.val > high)
                return RangeSumBST2(root.left, low, high);
            if (root.val >= low && root.val <= high)
                return root.val + RangeSumBST2(root.left, low, high) + RangeSumBST2(root.right, low, high);
            return 0;
        }
    }
}
