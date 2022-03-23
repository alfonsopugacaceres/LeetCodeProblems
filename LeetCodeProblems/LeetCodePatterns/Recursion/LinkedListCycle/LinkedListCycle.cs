using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Recursion.LinkedListCycle
{
    class LinkedListCycle
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }

        public bool HasCycleRecursive(ListNode head)
        {
            if (head == null)
                return false;

            HashSet<ListNode> set = new HashSet<ListNode>();
            return HasCycleRecursiveHelper(head, set);
        }

        public bool HasCycleRecursiveHelper(ListNode current, HashSet<ListNode> set)
        {
            if (current == null)
                return false;

            if (set.Contains(current))
                return true;

            set.Add(current);
            return HasCycleRecursiveHelper(current.next, set);
        }
    }
}
