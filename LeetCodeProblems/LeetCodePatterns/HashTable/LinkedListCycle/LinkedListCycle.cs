using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.HashTable.LinkedListCycle
{
    class LinkedListCycle
    {
        //141. Linked List Cycle
        //Given head, the head of a linked list, determine if the linked list has a cycle in it.
        //There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer.Internally, 
        //pos is used to denote the index of the node that tail's next pointer is connected to. Note that pos is not passed as a parameter.
        //Return true if there is a cycle in the linked list.Otherwise, return false.
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
