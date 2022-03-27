using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.TwoPointers.SortColors
{
    class SortColors
    {
        //75. Sort Colors
        //
        //Given an array nums with n objects colored red, white, or blue, sort them in-place so that objects of the same color are adjacent, with the colors in the order red, white, and blue.
        //We will use the integers 0, 1, and 2 to represent the color red, white, and blue, respectively.
        //You must solve this problem without using the library's sort function.
        public void SortColors1(int[] nums)
        {
            int left = 0;//left pointer is for 0s
            int right = nums.Length - 1;//right poiner is for 2s

            int swap = 0;
            for (int i = 0; i <= right;)//while i is less than or equal to the right side
            {
                if (nums[i] == 0 && i != left)//if you are at a 0 in the current slot, toss it to the left side
                {
                    swap = nums[left];
                    nums[left] = nums[i];
                    nums[i] = swap;
                    left++;//increment the left pointer so we dont touch the previous zero again
                    //NOTICE how we are not incrementing i, this is because we have no idea what i is anymore until we reprocess it
                }
                else if (nums[i] == 2 && i != right)//if we found a 2, toss it to the right side
                {
                    swap = nums[right];
                    nums[right] = nums[i];
                    nums[i] = swap;
                    right--;//increment the right pointer so we dont touch the previous 2 again
                    //NOTICE how we are not incrementing i, this is because we have no idea what i is anymore until we reprocess it
                }
                else
                    i++;//if its not a 0 or a 2 then we have a 1, so we do not swap. we just increment i
            }
        }
    }
}
