using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.SortArrayIncreasingFrequency
{
    class SortArrayIncreasingFrequency
    {
        //1636. Sort Array by Increasing Frequency
        //        Given an array of integers nums, sort the array in increasing order based on the frequency of the values.If multiple values have the same frequency, sort them in decreasing order.

        //Return the sorted array.
        public int[] FrequencySort(int[] nums)
        {
            IDictionary<int, int> memo = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if (memo.ContainsKey(nums[i]))
                    memo[nums[i]]++;
                else
                    memo.Add(nums[i], 1);
            }

            List<int> ordered = memo.OrderBy(f => f.Value).Select(n=>n.Key).ToList();
            List<int> ret = new List<int>();

            foreach (int num in ordered)
            {
                int times = memo[num];
                for (int i = times; i > 0; i--)
                    ret.Add(num);
            }

            return ret.ToArray();
            
        }
    }
}
