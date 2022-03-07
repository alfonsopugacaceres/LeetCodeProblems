using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.RemoveDuplicatesInArrayON
{
    public class RemoveDuplicatesInArrayON
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 1 || nums.Length > 30000)//edge cases
                return 0;
            else
            {
                if (nums.Length == 0) //if nums length is 0, return 0
                    return 0;
                int i = 0;//start a counter
                for (int j = 1; j < nums.Length; j++)//start a second counter one offset from the start
                {
                    if (nums[j] != nums[i])//if we find unique values (remember the array is sorter) then 
                    {
                        i++;//increment the counter, which will replace the number after our unique "i"
                        nums[i] = nums[j];//replace with the unique next number we found
                    }
                }
                return i + 1;//return the result plus one since we always count the first number as one
            }
        }
    }
}
