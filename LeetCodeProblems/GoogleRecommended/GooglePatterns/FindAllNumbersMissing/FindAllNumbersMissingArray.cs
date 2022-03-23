using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GoogleRecommended.GooglePatterns.FindAllNumbersMissing
{
    //448. Find All Numbers Disappeared in an Array

    //Given an array nums of n integers where nums[i] is in the range [1, n], return an array of all the integers in the range [1, n] that do not appear in nums.
    public class FindAllNumbersMissingArray
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            IDictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dictionary.ContainsKey(nums[i]))
                    dictionary.Add(nums[i], 1);
                else
                    dictionary[nums[i]]++;
            }

            IList<int> ret = new List<int>();
            for (int i = 1; i < nums.Length + 1; i++)
            {
                if (!dictionary.ContainsKey(i))
                    ret.Add(i);
            }

            return ret;
        }
    }
}
