using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.AmazonProblems
{
    public class TreeProblem
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
        };


        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            TreeNode root = s;
            while(root != null && root.val != t.val)
            {
                if(root.val < t.val)
                {
                    root = root.left;
                }
                else if(root.val > t.val)
                {
                    root = root.right;
                }
            }

            if(root == null)
            {
                return false;
            }
            else
            {
                return RecursiveTraversal(root, t);
            }
        }

        public bool RecursiveTraversal(TreeNode s, TreeNode t)
        {
            bool ret = true;
            if(s == null && t == null)
            {
                return true;
            }
            else if((s == null && t != null) || (s != null && t == null))
            {
                return false;
            }
            else if(s.val != t.val)
            {
                return false;
            }
            else
            {

                if (s.right == null && s.left == null && t.left == null && t.right == null && s.val == t.val)
                {
                    return true;
                }

                ret = ret && RecursiveTraversal(s.right, t.right);

                ret = ret && RecursiveTraversal(s.left, t.left);
            }

            return ret;
        }
    }
}


//bool ret = true;
//if (s == null && t == null)
//{
//    return true;
//}
//else if (s.val != t.val)
//{
//    return false;
//}
//else
//{

//    if (s.right == null && s.left == null && t.left == null && t.right == null && s.val == t.val)
//    {
//        return true;
//    }

//    if ((s.right == null && t.right != null) || (s.right != null && t.right == null) ||
//        (s.left != null && t.left == null) || (s.left == null && t.left != null)
//        )
//    {
//        return false;
//    }
//    else
//    {
//        ret = ret && RecursiveTraversal(s.right, t.right);
//    }

//    if ((s.left == null && t.left != null) || (s.left != null && t.left == null))
//    {
//        return false;
//    }
//    else
//    {
//        ret = RecursiveTraversal(s.left, t.left);
//    }
//}

//return ret;