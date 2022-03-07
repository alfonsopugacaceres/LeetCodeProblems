using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.SortedArrayToBST
{
    public class SortedArrayToBST
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
        public TreeNode SortedArrayToBST1(int[] nums)
        {
            return Helper(0, nums.Length - 1, nums);//call our recursive function
        }

        public TreeNode Helper(int left, int right, int[] nums)//using two pointers
        {
            if (left > right)//when the left is larger than the right we are finished
                return null;
            int midpoint = (left + right) / 2;//figure out the midpoint, the midpoint should be the middle node
            TreeNode root = new TreeNode(nums[midpoint]);//create a new root
            root.left = Helper(left, midpoint - 1, nums);//we call the helper function recursively, while also moving the midpoint down to fine the 
                                                         //next nodes midpoint
            root.right = Helper(midpoint + 1, right, nums);//we call the helper function recursively, while also moving the midpoint up to fine the 
                                                           //next nodes midpoint
            return root;
        }
    }
}
