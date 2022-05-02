using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.MinimumAbsoluteDifference
{
    class MinimumAbsoluteDifference
    {
        //1200. Minimum Absolute Difference
        //Given an array of distinct integers arr, find all pairs of elements with the minimum absolute difference of any two elements.
        //Return a list of pairs in ascending order(with respect to pairs), each pair[a, b] follows
        //a, b are from arr
        //a<b
        //b - a equals to the minimum absolute difference of any two elements in arr
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            Array.Sort(arr);
            int minDiff = int.MaxValue;
            IList<IList<int>> ret = new List<IList<int>>();

            for(int i = 0; i < arr.Length-1; i++)
            {
                int currentDiff = arr[i + 1] - arr[i];
                if (currentDiff == minDiff)
                    ret.Add(new List<int>() { arr[i], arr[i + 1] });
                else if (currentDiff < minDiff)
                {
                    ret.Clear();
                    ret.Add(new List<int>() { arr[i], arr[i + 1] });
                    minDiff = currentDiff;
                }
            }

            return ret;
        }
    }
}
