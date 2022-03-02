using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.MiddleOfTheLinkedList
{
    public class MiddleOfTheLinkedList
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
        public ListNode MiddleNode(ListNode head)
        {
            ListNode tempHead = head;
            int nodeCounter = 0;//create a counter variable
            while (head.next != null)
            {
                head = head.next;//advance the head
                nodeCounter++;//keep track of the node counter
            }
            int mid = -1;
            if (nodeCounter % 2 == 0)//if we have even nodes
                mid = nodeCounter / 2;//return the middle node
            else
            {
                mid = (int)(Math.Ceiling(nodeCounter / 2f));//otherwise, return the ceiling of the number of nodes / 2
            }
            while (mid > 0)//while the mid is greater than 0
            {
                tempHead = tempHead.next;//advance the temp head,
                mid--;//decrement mid
            }
            return tempHead;//return the temphead which should be the middle of the list

        }
        public ListNode MiddleNode2(ListNode head)
        {
            ListNode[] A = new ListNode[100];//create an array of listnodes
            int t = 0;//counter for the listnodes
            while (head != null)//while we are not at the end
            {
                A[t++] = head;//the node at slot t is the head, also increment the counter
                head = head.next;//advance the head
            }
            return A[t / 2];//divide the counter variable by 2, return the node at the slot

        }

    }
}
