using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GoogleRecommended.GooglePatterns.LinkedListCycle2
{
    class LinkedListCycle2
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
        public ListNode DetectCycle(ListNode head)
        {
            HashSet<ListNode> set = new HashSet<ListNode>();
            return FindCycleHelper(head, set);

        }

        public ListNode FindCycleHelper(ListNode head, HashSet<ListNode> set)
        {
            if (head == null)
                return null;
            if (set.Contains(head))
                return head;
            set.Add(head);
            return FindCycleHelper(head.next, set);
        }

        public ListNode FindIntersection(ListNode head)
        {
            ListNode slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                    return slow;
            }
            return null;

        }

        public ListNode DetectCycle2(ListNode head)
        {

            if (head == null)
                return null;

            ListNode slow = FindIntersection(head);

            if (slow == null)
                return null;

            ListNode slow2 = head;

            while (slow2 != slow)
            {
                slow = slow.next;
                slow2 = slow2.next;
            }
            return slow2;
        }
    }
}
