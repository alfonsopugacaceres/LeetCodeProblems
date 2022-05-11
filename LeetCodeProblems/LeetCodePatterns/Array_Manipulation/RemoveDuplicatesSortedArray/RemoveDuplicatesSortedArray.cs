using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.RemoveDuplicatesSortedArray
{
    //26. Remove Duplicates from Sorted Array
    //    Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once.The relative order of the elements should be kept the same.
    //Since it is impossible to change the length of the array in some languages, you must instead have the result be placed in the first part of the array nums.More formally, if there are k elements after removing the duplicates, then the first k elements of nums should hold the final result.It does not matter what you leave beyond the first k elements.
    //Return k after placing the final result in the first k slots of nums.
    //Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.

    /// <summary>
    /// 
    /// </summary>
    public class RemoveDuplicatesSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            int diff = 0;//keep track of skips
            int prev = nums[0];//initialize the previous


            for (int i = 1; i < nums.Length; i++)//loop through all nums
            {
                if (prev == nums[i])//check if the current is the same as the previous,
                    diff++;//if it is, increase the diff
                else
                    nums[i - diff] = nums[i];//using the tally of diff, create a mapping to the previous
                                             //illegal number to replace
                prev = nums[i];//always update the previous
            }

            return nums.Length - diff;//using the diff counter, return the end of the valid numbers
        }
    }
}
