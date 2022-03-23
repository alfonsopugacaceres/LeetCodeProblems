using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgrammingAlgorithms.LinkedListCycle
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
        /// <summary>
        /// Floyd's Cycle Finding Algorithm
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
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

    }
}
