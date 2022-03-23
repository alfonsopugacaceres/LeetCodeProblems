using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.HashTable.SingleNumber
{
    class SingleNumber
    {
        //TAGS Google Amazon Microsoft
        //136. Single Number
        //Given a non-empty array of integers nums, every element appears twice except for one.Find that single one.
        //You must implement a solution with a linear runtime complexity and use only constant extra space.

        /// <summary>
        /// This answer leverages a dictionary, the dictionary is populated with all the members, if we find a duplicate they are removed.
        /// This means that by the time we are finished with the loop we added and removed all the numbers which have duplicates.
        /// Therefore the only leftover number should be the answer
        /// </summary>
        /// <param name="nums">input array</param>
        /// <returns>number that was not duplicates</returns>
        public int SingleNumber1(int[] nums)
        {
            Dictionary<int, int> set = new Dictionary<int, int>();//create a dictionary
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.ContainsKey(nums[i]))//if we have the key
                    set.Remove(nums[i]);//remove the entry
                else
                    set.Add(nums[i], 1);//otherwise add the entry
            }

            return set.Keys.ToList()[0];//return the only leftover

        }

        /// <summary>
        /// This answer leverages a dictionary, the dictionary is populated with all the members, if we find a duplicate they are removed.
        /// This means that by the time we are finished with the loop we added and removed all the numbers which have duplicates.
        /// Therefore the only leftover number should be the answer
        /// If there was nothing in the leftover dictionary we return a sentinel value
        /// </summary>
        /// <param name="nums">input array</param>
        /// <returns>number that was not duplicates</returns>
        public int SingleNumber3(int[] nums)
        {
            IDictionary<int, bool> memo = new Dictionary<int, bool>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!memo.ContainsKey(nums[i]))
                    memo.Add(nums[i], true);
                else
                    memo.Remove(nums[i]);
            }

            foreach (KeyValuePair<int, bool> pair in memo)
                return pair.Key;

            return -30001;

        }
    }
}
