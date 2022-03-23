using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.PeakIndexMountainArray
{
    public class PeakIndexMountainArray
    {
        public int PeakIndexInMountainArray(int[] arr)
        {

            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max && arr[i + 1] < arr[i])
                    return i;
            }
            return -1;
        }
    }
}
