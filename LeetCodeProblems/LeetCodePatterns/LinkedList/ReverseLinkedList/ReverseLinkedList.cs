using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.LinkedList.ReverseLinkedList
{
    class ReverseLinkedList
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
        public ListNode ReverseList(ListNode head)
        {
            Stack<ListNode> s = new Stack<ListNode>();

            while (head != null)
            {
                s.Push(head);
                head = head.next;
            }

            ListNode start = null;
            ListNode previous = null;

            while (s.Count > 0)
            {
                ListNode current = s.Pop();
                if (previous != null)
                    previous.next = current;
                else
                    start = current;
                current.next = null;
                previous = current;
            }

            return start;
        }

        public ListNode ReverseList1(ListNode head)
        {

            ListNode reverse = null;//create some temporary variables
            ListNode traverse = null;
            while (head != null)//while the current head is not null
            {
                traverse = head.next;//keep track of the next node
                if (reverse != null)//check if the current reverse is null
                {
                    head.next = reverse;//if its not null, make the current head next point to the previous reverse
                    reverse = head;//make the new reverse be the head, essentially linking backwards
                }
                else
                {
                    reverse = head;//if the reverse is null, set it to the head
                    reverse.next = null;//remember to blank out the next pointer, otherwise you will make a circular list
                }
                head = traverse;//move the head up one space with the traversal variable
            }
            return reverse;//return the reversed linked list

        }
    }
}
