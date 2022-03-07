using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.SearchBST
{
    public class SearchInBST
    {
        //700. Search in a Binary Search Tree
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
        public TreeNode SearchBST(TreeNode root, int val)//searching the binary search tree recursively
        {
            if (root == null)//if you land in a null root return null
                return null;
            else if (root.left == null && root.right == null && root.val != val)//if you are at a leaf node and you dont have an answer return null
                return null;
            else
            {
                if (root.val == val)//if the values are the same return the root
                    return root;
                else if (root.val > val)//if the root is larger than the searched value, go to the left of the tree
                    return SearchBST(root.left, val);
                else
                    return SearchBST(root.right, val);//otherwise go to the right of the tree 
            }
        }
    }
}
