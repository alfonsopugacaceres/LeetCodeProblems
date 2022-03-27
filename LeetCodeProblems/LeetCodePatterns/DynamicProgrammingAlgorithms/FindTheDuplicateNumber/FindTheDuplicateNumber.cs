using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.DynamicProgrammingAlgorithms.FindTheDuplicateNumber
{
    class FindTheDuplicateNumber
    {
        //287. Find the Duplicate Number  
        //Given an array of integers nums containing n + 1 integers where each integer is in the range[1, n] inclusive.
        //There is only one repeated number in nums, return this repeated number.
        //You must solve the problem without modifying the array nums and uses only constant extra space.

        /// <summary>
        /// The only way to satisfy all of the conditions is to reduce this problem to Floyd's Algorithm.
        /// take a look at the array values, since we know we have numbers from 1=>n, and we have an array, and we only have ONE
        /// single duplicated digit, we can treat the values as a linked list. Then we just follow Floyds algorithm to find 
        /// the spot in which the CYCLE repeats, which is the repeated index.
        /// 
        /// Time Complexity O(n+m) and Space Complexity O(1)
        /// </summary>
        /// <param name="nums">array of integers</param>
        /// <returns>repeated number</returns>
        public int FindDuplicate(int[] nums)
        {
            int slow = nums[0];//create a slow pointer pointing at the very first number
            int fast = nums[0];//create a fast pointer pointing at the very first number

            while (true)//we basically loop forever until the pointers meet
            {
                slow = nums[slow];//this advances the pointer once
                fast = nums[nums[fast]];//this advances the pointer twice
                if (slow == fast)//when the pointers meet break out of the loop
                    break;
            }

            slow = nums[0];//set the slow pointer back at the beginning

            while(fast != slow)//while the slow pointer does not meet the fast pointer
            {
                slow = nums[slow];//increment the pointers, please notice the fast pointer now becomes a slow pointer as well
                fast = nums[fast];
            }

            return fast;//return either one since they should both meet at the cycle number

        }



    }
}

