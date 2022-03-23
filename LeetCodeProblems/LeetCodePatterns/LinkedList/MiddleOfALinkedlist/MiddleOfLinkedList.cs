using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.LinkedList.MiddleOfALinkedlist
{
    class MiddleOfLinkedList
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
        public ListNode MiddleNode(ListNode head)
        {

            List<ListNode> list = new List<ListNode>();

            if (head == null || head.next == null)
                return head;

            while (head != null)
            {
                list.Add(head);
                head = head.next;
            }

            if (list.Count % 2 != 0)
            {
                return list[(int)Math.Floor(list.Count / 2d)];
            }
            else
            {
                return list[list.Count / 2];
            }
        }

        public ListNode middleNode(ListNode head)
        {
            ListNode slow = head, fast = head;

            StringBuilder x = null;
            
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }

        public bool IsPalindrome(ListNode head)
        {

            StringBuilder ret = new StringBuilder();

            while (head != null && head.next != null)
            {
                ret.Append(head.val);
            }
            string retString = ret.ToString();

            for (int i = 0, j = retString.Length - 1; i < j; i++, j--)
            {
                if (retString[i] != retString[j])
                return false;
        }
        
        return true;
        
    }
}
}
