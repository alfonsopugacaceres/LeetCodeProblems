using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.MajorityElement
{
    class MajorityElement
    {
        //tags amazon microsoft

        //169. Majority Element
        //Given an array nums of size n, return the majority element.
        //The majority element is the element that appears more than ⌊n / 2⌋ times.You may assume that the majority element always exists in the array.

        /// <summary>
        /// Sort the array, then loop through the array one at a time keeping track of the counter for each individual number
        /// notice we reset it and keep comparing it to the max, at the end of the loop we should have the maximum number
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MajorityElement1(int[] nums)
        {
            Array.Sort(nums);//sort the array
            int max = 1;//start with a single case for the first number
            int maxNum = nums[0];//here is the first number
            int curCounter = 1;//cur counter
            for (int i = 1; i < nums.Length; i++)//loop through all numbers
            {
                if (nums[i] != nums[i - 1])//if the current is not the previous reset the counter
                    curCounter = 1;
                else
                    curCounter++;//otherwise increase the counter
                if (curCounter > max)//if the counter is greater than the max, then we have a new max
                {
                    maxNum = nums[i];//set the new number max
                    max = Math.Max(curCounter, max);//set the new max
                }
            }

            return maxNum;//return the max
        }
    }
}
