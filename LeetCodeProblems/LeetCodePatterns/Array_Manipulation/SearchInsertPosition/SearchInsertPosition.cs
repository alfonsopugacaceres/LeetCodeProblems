using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.SearchInsertPosition
{
    class SearchInsertPosition
    {
        /// <summary>
        /// solved using a binary search
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int SearchInsert(int[] nums, int target)
        {
            int pivot;//create a pivot
            int left = 0;//left pointer
            int right = nums.Length - 1;//right pointer

            while (left <= right)//while the pointer do not cross
            {
                pivot = left + (right - left) / 2;//generate the pivot
                if (nums[pivot] == target)//if the number at the pivot is the target
                    return pivot;//return the pivot
                if (target < nums[pivot])//if the target is less than the number at the pivot
                    right = pivot - 1;//change the right bound to be the pivot -1
                else
                    left = pivot + 1;//otherwise set the left to pivot +1
            }

            return left;//return the left if we reached here
        }
    }
}
