using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.LinkedList.RemoveLinkedListElements
{
    class RemoveLinkedListElements
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode RemoveElements(ListNode head, int val)
        {

            ListNode dummyHead = new ListNode(-1);
            dummyHead.next = head;
            ListNode current = dummyHead;

            while (current != null)
            {
                if (current.next != null && current.next.val == val)
                {
                    current.next = current.next.next;
                }
                else
                    current = current.next;
            }

            return dummyHead.next;
        }
    }
}
