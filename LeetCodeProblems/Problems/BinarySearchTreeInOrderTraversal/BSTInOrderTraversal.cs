using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.BinarySearchTreeInOrderTraversal
{
    //94. Binary Tree Inorder Traversal
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
    public class BSTInOrderTraversal
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> res = new List<int>();//create a list to store answer
            Helper(root, res);//run recursive function
            return res;//return answer
        }

        public void Helper(TreeNode root, IList<int> res)
        {
            if (root == null)//if the root is null return
                return;
            if (root.left != null)//if left is not null
                Helper(root.left, res);//call the recursive function
            res.Add(root.val);//add the current root value to the list, note its positioning, this means all the left nodes will print first, then the root, then right nodes
            if (root.right != null)
                Helper(root.right, res);//second recursive call

        }
    }
}
