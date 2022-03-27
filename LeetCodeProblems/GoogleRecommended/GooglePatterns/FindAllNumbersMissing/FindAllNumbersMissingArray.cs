using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GoogleRecommended.GooglePatterns.FindAllNumbersMissing
{
    //448. Find All Numbers Disappeared in an Array

    //Given an array nums of n integers where nums[i] is in the range [1, n], return an array of all the integers in the range [1, n] that do not appear in nums.

    public class FindAllNumbersMissingArray
    {
        /// <summary>
        /// Add all numbers from the array into a dictionary. After loop through all POSSIBILITIES between 1 and N, adding all the 
        /// missing numbers to a list and then returning it
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            IDictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dictionary.ContainsKey(nums[i]))//populate the dictionary
                    dictionary.Add(nums[i], 1);
                else
                    dictionary[nums[i]]++;
            }

            IList<int> ret = new List<int>();
            for (int i = 1; i < nums.Length + 1; i++)
            {
                if (!dictionary.ContainsKey(i))//check if possibility is not in the dictionary, if its not there add it to the result list
                    ret.Add(i);
            }

            return ret;//return the result list
        }
    }
}
