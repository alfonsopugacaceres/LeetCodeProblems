using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.FindAllTheLonelyNodes
{
    //1469. Find All The Lonely Nodes
    public class LonelyNodes
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
        public IList<int> GetLonelyNodes(TreeNode root)
        {
            IList<int> lonelyNodes = new List<int>();//create the list that will keep the result
            DFSTraversal(root, lonelyNodes);//pass the root and the list to the recursive function
            return lonelyNodes;//return the answer
        }

        void DFSTraversal(TreeNode root, IList<int> lonelyNodes)
        {
            if (root == null)//if the root is null return
                return;
            else if (root.left != null && root.right == null)//check for the lonely node condition
            {
                lonelyNodes.Add(root.left.val);//add to the list
                DFSTraversal(root.left, lonelyNodes);//continue recursion
            }
            else if (root.right != null && root.left == null)//check for the lonely node condition
            {
                lonelyNodes.Add(root.right.val);//add to the list
                DFSTraversal(root.right, lonelyNodes);//continue recursion
            }
            else
            {
                DFSTraversal(root.left, lonelyNodes);//even if there are no lonely nodes we have to continue the recursion
                DFSTraversal(root.right, lonelyNodes);//on all the nodes, therefore we call the function for both sides.
                                                      //we need to make sure we do not miss any nodes
            }
        }

        public IList<int> GetLonelyNodes1(TreeNode root)
        {
            IList<int> lonelyNodes = new List<int>();
            Helper(root, lonelyNodes);
            return lonelyNodes;

        }

        public void Helper(TreeNode root, IList<int> res)
        {
            if (root == null)
                return;
            if (root.left == null && root.right != null)
            {
                res.Add(root.right.val);
                Helper(root.right, res);
            }
            else if (root.right == null && root.left != null)
            {
                res.Add(root.left.val);
                Helper(root.left, res);
            }
            else
            {
                Helper(root.right, res);
                Helper(root.left, res);
            }
        }
    }
}
