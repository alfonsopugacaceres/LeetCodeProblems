using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.MergeTowSortedLists
{
    public class MergeTwoSortedLists
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

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)//if the list 1 is null, return list 2
                return list2;
            else if (list2 == null)//if list 2 is null, return list 1
                return list1;
            else
            {
                ListNode next = null;//create a temporary pointer so we can advance whichever list is less

                if (list1.val <= list2.val)
                {
                    next = list1;//set the temp pointer
                    next.next = MergeTwoLists(list1.next, list2);//set the next to the mergetwolists of the forward node and list 2
                }
                else
                {
                    next = list2;//set the temp pointer
                    next.next = MergeTwoLists(list1, list2.next);//set the next to the mergetwolists of the forward node and list 1

                }
                return next;//return next
            }
        }
    }
}
