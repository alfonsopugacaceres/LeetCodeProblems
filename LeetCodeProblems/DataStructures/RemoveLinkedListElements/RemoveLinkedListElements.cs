using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GoogleRecommended.GooglePatterns.RemoveLinkedListElements
{
    class RemoveLinkedListElements
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
        public ListNode RemoveElements(ListNode head, int val)
        {

            ListNode dummyHead = new ListNode(0, head);
            ListNode previous = dummyHead;

            while (head != null)
            {
                if (head.val == val)
                {
                    previous.next = head.next;
                }
                else
                    previous = head;
                head = head.next;
            }
            return dummyHead.next;

        }
    }
}
