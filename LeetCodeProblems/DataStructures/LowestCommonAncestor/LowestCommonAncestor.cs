using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GoogleRecommended.GooglePatterns.LowestCommonAncestor
{
    class LowestCommonAncestor
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        public TreeNode LowestCommonAncestor1(TreeNode root, TreeNode p, TreeNode q)
        {
            // Value of current node or parent node.
            int parentVal = root.val;

            // Value of p
            int pVal = p.val;

            // Value of q;
            int qVal = q.val;

            if (pVal > parentVal && qVal > parentVal)
            {
                // If both p and q are greater than parent
                return LowestCommonAncestor1(root.right, p, q);
            }
            else if (pVal < parentVal && qVal < parentVal)
            {
                // If both p and q are lesser than parent
                return LowestCommonAncestor1(root.left, p, q);
            }
            else
            {
                // We have found the split point, i.e. the LCA node.
                return root;
            }
        }
    }
}
