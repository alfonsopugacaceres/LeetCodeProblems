using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Backtracking.BinaryTreePaths
{
    //257. Binary Tree Paths
    //Given the root of a binary tree, return all root-to-leaf paths in any order.
    //A leaf is a node with no children

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
    class BinaryTreePaths
    {
        public IList<string> BinaryTreePaths1(TreeNode root)
        {
            IList<string> res = new List<string>();
            Backtrack(root, string.Empty, res);
            return res;
        }

        public void Backtrack(TreeNode root, string currentTraversal, IList<string> res)
        {
            if (root == null)//if the root is null return
                return;
            if (root.left == null && root.right == null)//if the root left and the root right are both null then 
            {                                           //finish off the traversal string and add it to the answer
                currentTraversal += root.val;
                res.Add(currentTraversal);
                return;
            }

            if(root.left != null)//if left is not null call backtrack on left
                Backtrack(root.left, currentTraversal + root.val + "->", res);
            if (root.right != null)//if right is not null call backtrack on right
                Backtrack(root.right, currentTraversal + root.val + "->", res);
        }
    }
}
