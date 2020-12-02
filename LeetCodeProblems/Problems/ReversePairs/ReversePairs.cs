using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.ReversePairs
{
    public class ReversePairs
    {

        //important reverse pair if i < j and nums[i] > 2*nums[j]
        public int BruteForceReversePairs(int[] nums)
        {
            int res = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if(nums[j] > (2 * nums[i]))
                    {
                        res++;
                    }
                }
            }
            return res;
        }

        public class Node
        {
            public Node Left {get;set; }
            public Node Right { get; set; }
            public int Data { get; set; }

            public Node(int newdata)
            {
                Left = null;
                Right = null;
                Data = newdata;
            }
        }

        public class BinarySearchTree
        {
            Node root;
            int count;

            public BinarySearchTree()
            {
                count = 0;
            }

            public void Add(int newData)
            {
                if(count == 0)
                {
                    root = new Node(newData);
                }
                else
                {
                    Node target = Find(newData, root);
                    if(target == null)
                    {
                        target = new Node(newData);
                        count++;
                    }
                    else
                    {
                        count++;
                    }
                }
            }

            public Node Find(int searchKey, Node currentRoot)
            {
                if(searchKey > currentRoot.Data)
                {
                    return Find(searchKey, currentRoot.Right);
                }
                else if (searchKey < currentRoot.Data)
                {
                    return Find(searchKey, currentRoot.Left);
                }
                else
                {
                    return currentRoot;
                }
            }
        }

        public int ReversePairs(int[] nums)
        {
            IDictionary<int, int> passedIs = new Dictionary<int, int>();
            IDictionary<int, int[]> validids = new Dictionary<int, int[]>();
            Stack<int> stackedNums = new Stack<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                //passedIs.Add(i, 2*nums[i]);
                //validids.Add(i, new int[i + 1]);
                stackedNums.Push(2 * nums[i]);
            }

            for(int i = nums.Length; i > 0; i++)
            {
                int j = i - 1;
                while (j > 0 && stackedNums.Peek() < nums[i])
                {

                }
            }

        }

    }
}
