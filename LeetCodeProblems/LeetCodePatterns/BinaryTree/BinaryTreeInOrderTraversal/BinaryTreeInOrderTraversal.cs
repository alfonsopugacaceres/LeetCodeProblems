using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.BinaryTree.BinaryTreeInOrderTraversal
{
    class BinaryTreeInOrderTraversal
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
            public IList<int> InorderTraversal(TreeNode root)
            {
                IList<int> list = new List<int>();
                helper(root, list);
                return list;
            }

            public void helper(TreeNode root, IList<int> list)
            {
                if (root == null)
                    return;

                helper(root.left, list);
                list.Add(root.val);
                helper(root.right, list);
            }
        }
    }
}
