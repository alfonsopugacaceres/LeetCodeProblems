using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.HashTable.UniqueNumberOfOccurrences
{
    class UniqueNumberOfOccurrences
    {
        //1207. Unique Number of Occurrences
        //Given an array of integers arr, return true if the number of occurrences of each value in the array is unique, or false otherwise.
        public bool UniqueOccurrences1(int[] arr)
        {

            IDictionary<int, int> memo = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (memo.ContainsKey(arr[i]))
                    memo[arr[i]]++;
                else
                    memo.Add(arr[i], 1);
            }


            HashSet<int> set = new HashSet<int>();
            foreach (KeyValuePair<int, int> pair in memo)
            {
                if (set.Contains(pair.Value))
                    return false;
                else
                    set.Add(pair.Value);
            }
            return true;
        }
    }
}
