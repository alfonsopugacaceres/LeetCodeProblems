using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.DeleteNodeReturnForest
{
    public class DeleteNodeReturnForest
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

        public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
        {
            IList<TreeNode> forest = new List<TreeNode>();

            //populate a hashset to quickly find if values must be deleted or not
            HashSet<int> todeleteset = new HashSet<int>();

            for (int i = 0; i < to_delete.Length; i++)
            {
                todeleteset.Add(to_delete[i]);
            }

            RemoveTargets(root, todeleteset, forest);

            //if the value of the root was not deleted, add it to the forest
            if (!todeleteset.Contains(root.val))
            {
                forest.Add(root);
            }

            return forest;
        }

        public TreeNode RemoveTargets(TreeNode root, HashSet<int> to_delete, IList<TreeNode> forest)
        {
            if(root == null)
            {
                return null;
            }
            else
            {
                //recursively call remote targets to the left until we hit the base case, same for the right side.
                //the base case gurantees that we will be looking at nodes locates as leaves, which means we can 
                //delete them easily, if we didn't go bottom up we would have difficulties or added complexity 
                //from keeping tack of old trees. With a bottom up approach we are making sure that as we 
                //break the tree we add it to the result set minimizing computation

                root.left = RemoveTargets(root.left, to_delete, forest);
                root.right = RemoveTargets(root.right, to_delete, forest);

                if (to_delete.Contains(root.val))
                {
                    if(root.right != null)
                    {
                        forest.Add(root.right);
                    }
                    if(root.left != null)
                    {
                        forest.Add(root.left);
                    }
                    return null;
                }
                else
                {
                    return root;
                }
            }
        }

    }
}
