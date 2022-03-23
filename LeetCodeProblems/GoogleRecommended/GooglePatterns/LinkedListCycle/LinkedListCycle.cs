using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GoogleRecommended.GooglePatterns.LinkedListCycle
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
        public bool HasCycle(ListNode head)
        {
            HashSet<ListNode> set = new HashSet<ListNode>();
            if (head == null || head.next == null)
                return false;


            set.Add(head);
            while (head != null && head.next != null)
            {
                head = head.next;
                if (set.Contains(head))
                    return true;
                else
                    set.Add(head);
            }

            return false;

        }

        public bool HasCycleFastSlowPointe(ListNode head)
        {
            if (head == null || head.next == null)
                return false;

            ListNode slow = head;
            ListNode fast = head.next;

            while(slow != fast)
            {
                if (fast.next == null || fast.next.next == null)
                    return false;
                slow = slow.next;
                fast = fast.next.next;
            }

            return true;
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
