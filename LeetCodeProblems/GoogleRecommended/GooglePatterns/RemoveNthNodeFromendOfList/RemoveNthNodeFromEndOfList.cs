using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GoogleRecommended.GooglePatterns.RemoveNthNodeFromendOfList
{
    class RemoveNthNodeFromEndOfList
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
            public ListNode RemoveNthFromEnd(ListNode head, int n)
            {

                ListNode dummyHead = new ListNode();
                dummyHead.next = head;
                ListNode pointer1 = dummyHead;
                ListNode pointer2 = dummyHead;

                for (int i = 1; i <= n + 1; i++)
                    pointer1 = pointer1.next;

                while (pointer1 != null)
                {
                    pointer2 = pointer2.next;
                    pointer1 = pointer1.next;
                }

                pointer2.next = pointer2.next.next;
                return dummyHead.next;
            }
         
        }
    }
}