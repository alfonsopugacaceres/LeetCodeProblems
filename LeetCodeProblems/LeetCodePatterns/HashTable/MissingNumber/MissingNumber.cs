using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.HashTable.MissingNumber
{
    public class MissingNumber
    {
        //TAGS Google Amazon Microsoft
        //268. Missing Number
        //Given an array nums containing n distinct numbers in the range[0, n], return the only number in the range that is missing from the array.
        /// <summary>
        /// Use a hashset to determine if there is a missing number
        /// </summary>
        /// <param name="nums">input array</param>
        /// <returns>the duplicates number</returns>
        public int MissingNumber1(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();//create a hash set
            for (int i = 0; i < nums.Length; i++)//add all the numbers in the array
                set.Add(nums[i]);      

            for (int i = 0; i < nums.Length + 1; i++)//since we know there is 1 single number missing, just check that the set 
            {                                        //contains all numbers with a simple for loop up to nums.Length + 1
                if (!set.Contains(i))//if we dont find the target i
                    return i;//return i, which should be the missing number
            }
            return -1;//return -1 if there was no missing number
        }
    }
}
