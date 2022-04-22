using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Backtracking.AllPossibleFullBinaryTree
{
    class AllPossibleFullBinaryTree
    {
        //894. All Possible Full Binary Trees

        //Given an integer n, return a list of all possible full binary trees with n nodes.Each node of each tree in the answer must have Node.val == 0.
        //Each element of the answer is the root node of one possible tree.You may return the final list of trees in any order.
        //A full binary tree is a binary tree where each node has exactly 0 or 2 children.    
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
        public IList<TreeNode> AllPossibleFBT(int n)
        {
            IDictionary<int, IList<TreeNode>> memo = new Dictionary<int, IList<TreeNode>>();
            return GenerateAllFullTrees(n, memo);
        }

        public IList<TreeNode> GenerateAllFullTrees(int n, IDictionary<int, IList<TreeNode>> memo)
        {
            if (n == 0)
                return new List<TreeNode>();
            if (n == 1)
                return new List<TreeNode>() { new TreeNode() };
            if (memo.ContainsKey(n))
                return memo[n];

            IList<TreeNode> currentList = new List<TreeNode>();
            for (int l = 0; l < n; l++)
            {
                int r = n - 1 - l;
                IList<TreeNode> leftTree = GenerateAllFullTrees(r, memo);
                IList<TreeNode> rightTree = GenerateAllFullTrees(l, memo);
                foreach (TreeNode left in leftTree)
                    foreach (TreeNode right in rightTree)
                        currentList.Add(new TreeNode(0, left, right));
            }

            memo.Add(n, currentList);

            return currentList;
        }

    }
}

