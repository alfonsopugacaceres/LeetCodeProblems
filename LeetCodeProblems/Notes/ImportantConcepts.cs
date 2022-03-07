using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Notes
{
    public class ImportantConcepts
    {
        public class BinaryTreeNode
        {
            public int val { get; set; }
            public BinaryTreeNode left { get; set; }
            public BinaryTreeNode right { get; set; }
        }

        #region DepthFirstSearch

        /// <summary>
        /// In Order Traversal for a binary tree, we use the list to store the values in the correct order
        /// note the left most root shows up first, then the middle node, then the right hand side
        /// </summary>
        /// <param name="root">root of the binary tree</param>
        /// <param name="ret">list to populate with the values of the tree</param>
        public void InOrderTraversal(BinaryTreeNode root, IList<int> ret)
        {
            if (root == null)//if the root is null just return out of the function
                return;
            if (root.left != null)//if the root left is not null run the recursive call on the left
                InOrderTraversal(root.left, ret);

            ret.Add(root.val);//add the current root to the list after completing the stack calls on the left

            if (root.right != null)//if the root right is not null run the recursive calls on the right
                InOrderTraversal(root.right, ret);
        }

        /// <summary>
        /// Post Order Traversal for a binary tree, we use the list to store the values in the correct order
        /// note the right most root shows up first, then the middle node, then the left node
        /// </summary>
        /// <param name="root">root of the binary tree</param>
        /// <param name="ret">list to populate with the values of the tree</param>
        public void PostOrderTraversal(BinaryTreeNode root, IList<int> ret)
        {
            if (root == null)//if the root is null just return out of the function
                return;

            if (root.right != null)//if the root right is not null run the recursive calls on the right
                PostOrderTraversal(root.right, ret);

            ret.Add(root.val);//add the current root to the list after completing the stack calls on the left

            if (root.left != null)//if the root left is not null run the recursive call on the left
                PostOrderTraversal(root.left, ret);

        }

        /// <summary>
        /// Pre Order Traversal for a binary tree, we use the list to store the values in the correct order.
        /// note roots always show first in this traversal
        /// </summary>
        /// <param name="root">root of the binary tree</param>
        /// <param name="ret">list to populate with the values of the tree</param>
        public void PreOrderTraversal(BinaryTreeNode root, IList<int> ret)
        {
            if (root == null)
                return;

            ret.Add(root.val);//add the current root to the list after completing the stack calls on the left

            if (root.left != null)//if the root left is not null run the recursive call on the left
                PreOrderTraversal(root.left, ret);

            if (root.right != null)//if the root right is not null run the recursive calls on the right
                PreOrderTraversal(root.right, ret);

        }

        /// <summary>
        /// Breath first traversals print out the values based on level of the tree.
        /// by leveraging a queue we can make sure to print out based on FIFO mode, allowing 
        /// us to enqueue more items without altering the result.
        /// </summary>
        /// <param name="root">root of the binary tree</param>
        /// <param name="ret">list to populate with the values of the tree</param>
        public void BreadthFirstTraversal(BinaryTreeNode root, IList<int> ret)
        {
            if (root == null)
                return;

            Queue<BinaryTreeNode> queue = new Queue<BinaryTreeNode>();
            queue.Enqueue(root);

            while(queue.Count > 0)
            {
                BinaryTreeNode curVal = queue.Dequeue();
                ret.Add(curVal.val);

                if (root.left != null)
                    queue.Enqueue(root.left);
                if (root.right != null)
                    queue.Enqueue(root.right);
            }
        }

        #endregion

    }
}
