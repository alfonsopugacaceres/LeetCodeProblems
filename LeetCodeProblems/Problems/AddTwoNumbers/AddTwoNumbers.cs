using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.AddTwoNumbers
{
    class AddTwoNumbers
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
        public ListNode AddTwoNumbers1(ListNode l1, ListNode l2)
        {

            if (l1 == null && l2 == null)
                return null;

            ListNode res = null;
            ListNode current = null;
            ListNode previous = null;
            int previousRemainder = 0;
            while (l1 != null || l2 != null)
            {
                int currentSum = ((l1 == null) ? 0 : l1.val) + ((l2 == null) ? 0 : l2.val) + previousRemainder;
                previousRemainder = currentSum / 10;
                currentSum = currentSum % 10;
                current = new ListNode(currentSum);
                if (previous == null)
                    res = current;
                else
                    previous.next = current;
                previous = current;
                l1 = (l1 == null) ? null : l1.next;
                l2 = (l2 == null) ? null : l2.next;
            }

            if (previousRemainder > 0)
            {
                previous.next = new ListNode(previousRemainder);
            }

            return res;

        }
    }
}
