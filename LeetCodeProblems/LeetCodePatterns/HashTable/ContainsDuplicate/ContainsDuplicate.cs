using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.HashTable.ContainsDuplicate
{
    public class ContainsDuplicate
    {
        //TAGS Google Amazon Microsoft
        //217 Contains Duplicate

        //Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
        /// <summary>
        /// Use a hashset to solve this problem. 
        /// 
        /// Time complexity: O(n) for one single loop around all members
        /// Space Complexity: O(n) for the hashset
        /// </summary>
        /// <param name="nums">input array</param>
        /// <returns>true if there is a duplicate in the array, false otherwise</returns>
        public bool ContainsDuplicate1(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();//create a hashset

            for(int i = 0; i < nums.Length; i++)//loop through all the members of the input array
            {
                if (set.Contains(nums[i]))//if the set already contains the current number, then we must have added it before. Therefore we found the duplicate
                    return true;
                else
                    set.Add(nums[i]);//if the number is not in the set, add the number to the set
            }
            return false;//if by the end of the loop we have not reached duplicate, return false to show there were no duplicates
        }
    }
}
