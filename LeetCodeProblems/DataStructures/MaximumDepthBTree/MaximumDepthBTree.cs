using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.MaximumDepthBTree
{
    public class MaximumDepthBTree
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

        public int MaxDepth(TreeNode root)
        {
            if(root == null)
            {
                return 0;
            }
            return DFS(root, 1);
        }

        public int DFS(TreeNode curRoot, int level)
        {
            int left = 0;
            int right = 0;

            if(curRoot.left == null && curRoot.right == null)
            {
                return level;
            }
            if(curRoot.left != null)
            {
                left = DFS(curRoot.left, level + 1);
            }
            if (curRoot.right != null)
            {
                right = DFS(curRoot.right, level + 1);
            }
            return Math.Max(left, right);

        }

        public int MaxDepth1(TreeNode root)
        {

            if (root == null)
            {
                return 0;
            }
            return DFS1(root, 1);
        }
        public int DFS1(TreeNode curRoot, int level)
        {
            if (curRoot == null)
                return level - 1;
            else
            {
                return Math.Max(DFS1(curRoot.left, level + 1), DFS1(curRoot.right, level + 1));
            }
        }
    }
}