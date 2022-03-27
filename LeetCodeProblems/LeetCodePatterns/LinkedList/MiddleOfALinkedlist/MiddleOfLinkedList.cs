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


        //876. Middle of the Linked List
        //Given the head of a singly linked list, return the middle node of the linked list.
        //If there are two middle nodes, return the second middle node.

        /// <summary>
        /// Use a list to keep track of the traversal and return the middle node
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode MiddleNode(ListNode head)
        {

            List<ListNode> list = new List<ListNode>();//make a list to keep track of all the nodes

            if (head == null || head.next == null)
                return head;

            while (head != null)//traverse the linked list and add all the nodes to it
            {
                list.Add(head);
                head = head.next;
            }

            return list[list.Count / 2];//return the middle of the list
        }

        /// <summary>
        /// Use a slow and a fast pointer, both start at the head node, then using the fact that the fast
        /// as the slow pointer, once we reach the end of the list we can say we have the middle of the
        /// list at the slow pointer
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode middleNode(ListNode head)
        {
            ListNode slow = head, fast = head;//both pointers start at the same node

            StringBuilder x = null;
            
            while (fast != null && fast.next != null)//while fast is not null or the next node is not null
            {
                slow = slow.next;//increment slow once
                fast = fast.next.next;//increment fast twice
            }
            return slow;//return the slow pointer which should be at half the distance
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
