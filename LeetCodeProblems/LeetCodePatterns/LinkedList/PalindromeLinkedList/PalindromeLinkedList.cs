using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.LinkedList.PalindromeLinkedList
{
    class PalindromeLinkedList
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
        /// <summary>
        /// The strategy revolves around getting all the values of the list in some sort of array like a List. Once we have the list we know
        /// palindromes are words which can be revered, there are two cases, either an odd number of characters word or an even number character word.
        /// Odd number words have a middle node that can be anything, even number words have to be identical.
        /// By using two pointers and iterating from front to back, and back to front, we compare all characters, if we ever find a mistmatch return false
        /// otherwise we break out of the loop when i > j, this takes care of the case for odds and evens very cleanly
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool IsPalindrome(ListNode head)
        {

            ListNode origin = head;
            IList<int> list = new List<int>();
            while (origin != null)
            {
                list.Add(origin.val);
                origin = origin.next;
            }

            if (list.Count == 0 || list.Count == 1)
                return true;

            int i = 0;
            int j = list.Count - 1;
            while (i < j)
            {
                if (list[i] != list[j])
                    return false;
                j--;
                i++;
            }
            return true;

        }
    }
}
