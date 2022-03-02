using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.FindLeavesBinaryTree
{
    public class FindLeavesBinaryTree
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
        public IList<IList<int>> FindLeaves(TreeNode root)
        {
            List<IList<int>> result = new List<IList<int>>();
            while(root.left !=null || root.right != null)
            {
                IList<int> tempList = new List<int>();//temp list for leaves
                RecursiveLeaveRemoval(root, ref root.right, ref tempList);//parameters are refs so we can both delete and add in the function
                RecursiveLeaveRemoval(root, ref root.left, ref tempList);//parameters are refs so we can both delete and add in the function
                result.Add(tempList);//add result list
            }
            result.Add(new List<int>() { root.val});//add the root to the result list
            return result;//return result
        }

        void RecursiveLeaveRemoval(TreeNode originalRoot, ref TreeNode root, ref IList<int> removed)
        {
            if (root == originalRoot)//if we are at the original root return
                return;
            else if (root == null)//if the root is null return
                return;
            else if (root.left == null && root.right == null)//if the root is a leafe add to the list and delete it by setting the root to null
            {
                removed.Add(root.val);
                root = null;
            }
            else
            {
                RecursiveLeaveRemoval(originalRoot, ref root.left, ref removed);//if we are not a leave, call the function again for the left and the right
                RecursiveLeaveRemoval(originalRoot, ref root.right, ref removed);
            }
        }
    }
}
