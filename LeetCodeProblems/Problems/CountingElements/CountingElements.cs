using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.CountingElements
{
    public class CountingElements
    {
        public int CountElements(int[] arr)
        {
            IDictionary<int, int> dict = new Dictionary<int, int>();
            int counter = 0;


            //populate an array, keep count of how many times a key is found
            for(int i = 0; i < arr.Length; i++)
            {
                if (!dict.ContainsKey(arr[i]))
                {
                    dict.Add(arr[i], 1);
                }
                else
                {
                    dict[arr[i]]++;
                }
            }

            //loop through the keys, add the number of times the key was present IF THE KEY + 1 IS IN THE DICTIONARY
            foreach(int key in dict.Keys)
            {
                if (dict.ContainsKey(key + 1))
                {
                    counter += dict[key];
                }
            }

            return counter;
        }
    }
}
