using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Searches.BinarySearch
{
    public class BinarySearch
    {
        /// <summary>
        /// Binary Search
        /// </summary>
        /// <param name="arr">Has to be a sorted array</param>
        /// <param name="target"></param>
        /// <returns></returns>
        int Search(int[] arr, int target)
        {
            return RecursiveBinarySearch(arr, target, 0, arr.Length - 1);
        }

        int RecursiveBinarySearch(int[]arr, int target, int left, int right)
        {
            if(left > right)
            {
                return -1;
            }
            else
            {
                int mid = (left + right) / 2;
                if(arr[mid] == target)
                {
                    return mid;
                }
                else if(target < arr[mid])
                {
                    return RecursiveBinarySearch(arr, target, left, mid-1);
                }
                else
                {
                    return RecursiveBinarySearch(arr, target, mid + 1, right);
                }
            }
        }
    }
}
