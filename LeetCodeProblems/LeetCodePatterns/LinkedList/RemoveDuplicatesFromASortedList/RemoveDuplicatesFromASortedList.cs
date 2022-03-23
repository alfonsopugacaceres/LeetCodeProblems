using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.LinkedList.RemoveDuplicatesFromASortedList
{
    class RemoveDuplicatesFromASortedList
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
        public ListNode DeleteDuplicates(ListNode head)
        {

            ListNode dummyHead = new ListNode(-1);
            HashSet<int> set = new HashSet<int>();

            dummyHead.next = head;
            ListNode current = dummyHead;

            while (current != null && current.next != null)
            {
                if (set.Contains(current.next.val))
                {
                    current.next = current.next.next;
                }
                else
                {
                    set.Add(current.next.val);
                    current = current.next;
                }
            }

            return dummyHead.next;

        }
    }
}
