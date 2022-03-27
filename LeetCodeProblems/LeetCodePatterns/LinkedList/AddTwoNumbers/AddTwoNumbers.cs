using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.LinkedList.AddTwoNumbers
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
            ListNode current = new ListNode();
            ListNode ret = current;
            int carryOver = 0;

            while (l1 != null || l2 != null)
            {
                int x = 0;
                int y = 0;

                if (l1 != null)
                    x = l1.val;
                if (l2 != null)
                    y = l2.val;

                current.val = x + y + carryOver;
                if (current.val / 10 >= 1)
                {
                    carryOver = 1;
                    current.val = current.val % 10;
                }
                else
                    carryOver = 0;
                if ((l1 != null && l1.next != null) || (l2 != null && l2.next != null))
                {
                    current.next = new ListNode();
                    current = current.next;
                }
                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;
            }

            if (carryOver >= 1)
                current.next = new ListNode(1);

            return ret;
        }
    }
}
