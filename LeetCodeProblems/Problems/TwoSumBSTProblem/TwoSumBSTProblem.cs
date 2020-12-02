using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.Problems.AmazonProblems.TwoSumBSTProblem
{
    public class TwoSumBSTProblem
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

            public bool TwoSumBSTs(TreeNode root1, TreeNode root2, int target)
            {
                bool atLeastOne = false;
                TreeNode origin = root1;
                TreeNode traversal = root1;
                IList<TreeNode> list = new List<TreeNode>();
                inorder(root1, list);
                foreach (TreeNode n in list)
                {
                    if (RecursiveSum(n, root2, target))
                    {
                        atLeastOne = true;
                        return true;
                    }
                }
                

                return atLeastOne;
            }

            public void inorder(TreeNode root, IList<TreeNode> nums)
            {
                if (root == null) return;
                inorder(root.left, nums);
                nums.Add(root);
                inorder(root.right, nums);
            }

            public bool RecursiveSum(TreeNode root1, TreeNode root2, int target) 
            {
                int targetVal = target - root1.val;
                if(root2 == null)
                {
                    return false;
                }
                else if (targetVal > root2.val)
                {
                    return RecursiveSum(root1, root2.right, target);
                }
                else if (targetVal < root2.val)
                {
                    return RecursiveSum(root1, root2.left, target);
                }
                else
                {
                    return true;
                }
            }

        }
    }
}
