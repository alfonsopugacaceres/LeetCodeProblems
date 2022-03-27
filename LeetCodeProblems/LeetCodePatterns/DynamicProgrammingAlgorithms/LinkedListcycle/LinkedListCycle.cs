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
        /// Floyd's Cycle Finding Algorithm. This is just the first part of the Floyd's cycle finding algorithm.
        /// This first portion only determines if there is a cycle on the linked list by using a fast and slow pointer
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool HasCycleFastSlowPointer(ListNode head)
        {
            if (head == null || head.next == null)
                return false;

            ListNode slow = head;
            ListNode fast = head;

            while(true)
            {
                if (slow == null || slow.next == null || 
                    fast == null || fast.next == null || 
                    fast.next.next == null)//these conditions detect we are not on a linked list with a cycle
                    return false;

                slow = slow.next;
                fast = fast.next.next;

                if (fast == slow)//if we ever end up on the same node, we have a linked list with a cycle
                    return true;

                
            }
        }

    }
}
