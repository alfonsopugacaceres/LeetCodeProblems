using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Trees
{
    public class BinaryTree
    {
        private BasicNode _root;

        public BinaryTree(BasicNode root)
        {
            _root = root;
        }

        public bool Add(int key)
        {
            BasicNode newNode = new BasicNode(key);
            BasicNode closestParent = Find(key);
            if(_root != null)
            {
                if (newNode.Key > closestParent.Key)
                {
                    closestParent.Right = newNode;
                    return true;
                }
                else if (newNode.Key < closestParent.Key)
                {
                    closestParent.Left = newNode;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                _root = newNode;
                return true;
            }
        }


        public BasicNode Find(int key)
        {
            return RecursiveFindExact(key, _root);
        }

        protected BasicNode FindClosest(int key)
        {
            return RecursiveFindClosest(key, _root);
        }


        /// <summary>
        /// Recursive Traversal of Binary Search Tree
        /// </summary>
        /// <param name="key"></param>
        /// <param name="node"></param>
        /// <returns>Node Matching key or node closest to matching the key</returns>
        protected BasicNode RecursiveFindExact(int key, BasicNode node)
        {
            if(node == null)
            {
                return null;
            }
            else if(key < node.Key)
            {
                return (node.Left == null) ? node : RecursiveFindExact(key, node.Left);
            }
            else if (key > node.Key)
            {
                return (node.Right == null) ? node : RecursiveFindExact(key, node.Right);
            }
            else
            {
                return node;
            }
        }

        protected BasicNode RecursiveFindClosest(int key, BasicNode node)
        {
            if (key < node.Key)
            {
                return (node.Left == null) ? node : RecursiveFindClosest(key, node.Left);
            }
            else if (key > node.Key)
            {
                return (node.Right == null) ? node : RecursiveFindClosest(key, node.Right);
            }
            else
            {
                return node;
            }
        }
    }
}
