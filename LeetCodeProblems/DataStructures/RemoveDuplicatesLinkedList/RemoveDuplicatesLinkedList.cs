using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GoogleRecommended.GooglePatterns.RemoveDuplicatesLinkedList
{
    class RemoveDuplicatesLinkedList
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
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode dummyHead = new ListNode(0, head);
            ListNode prev = dummyHead;
            HashSet<int> set = new HashSet<int>();

            while (head != null)
            {
                if (set.Contains(head.val))
                    prev.next = head.next;
                else
                {
                    prev = head;
                    set.Add(head.val);
                }
                head = head.next;


            }

            return dummyHead.next;
        }
    }
}
