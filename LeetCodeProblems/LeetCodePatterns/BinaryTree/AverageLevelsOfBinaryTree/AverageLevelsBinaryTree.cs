using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.BinaryTree.AverageLevelsOfBinaryTree
{
    class AverageLevelsBinaryTree
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

            public IList<double> AverageOfLevels(TreeNode root)
            {
                IDictionary<int, IList<double>> memo = new Dictionary<int, IList<double>>();
                IList<double> ret = new List<double>();
                Helper(memo, root, 0);

                foreach (KeyValuePair<int, IList<double>> pair in memo)
                {
                    double cur = 0;
                    foreach (double number in pair.Value)
                    {
                        cur += number;
                    }

                    cur = cur / pair.Value.Count;
                    ret.Add(cur);
                }

                return ret;

            }

            public void Helper(IDictionary<int, IList<double>> memo, TreeNode root, int level)
            {
                if (root == null)
                    return;

                if (memo.ContainsKey(level))
                    memo[level].Add(root.val);
                else
                {
                    memo.Add(level, new List<double>() { root.val });
                }
                Helper(memo, root.left, level + 1);
                Helper(memo, root.right, level + 1);
            }
        }
    }
}