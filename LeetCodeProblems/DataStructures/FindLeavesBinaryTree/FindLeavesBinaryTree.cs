using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GoogleRecommended.GooglePatterns.FindLeavesBinaryTree
{
    class FindLeavesBinaryTree
    {

        //Given the root of a binary tree, collect a tree's nodes as if you were doing this:
        //Collect all the leaf nodes.
        //Remove all the leaf nodes.
        //Repeat until the tree is empty.

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
            IList<IList<int>> res = new List<IList<int>>();

            if (root == null)
                return res;

            AddLeavesByLevel(root, res);
            return res;
        }

        int AddLeavesByLevel(TreeNode root, IList<IList<int>> res)
        {

            if (root == null)
                return 0;
            else
            {
                int level = Math.Max(AddLeavesByLevel(root.left, res), AddLeavesByLevel(root.right, res)) + 1;

                if (res.Count < level)
                    res.Add(new List<int>());
                res[level - 1].Add(root.val);
                return level;
            }

        }

    }
}
