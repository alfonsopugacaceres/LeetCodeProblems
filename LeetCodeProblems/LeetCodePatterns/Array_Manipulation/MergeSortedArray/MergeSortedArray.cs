using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.MergeSortedArray
{

    //88. Merge Sorted Array
    //You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and
    ////two integers m and n, representing the number of elements in nums1 and nums2 respectively.
    //Merge nums1 and nums2 into a single array sorted in non-decreasing order.
    //The final sorted array should not be returned by the function, but instead be stored
    //inside the array nums1. To accommodate this, nums1 has a length of m + n, where the
    //first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
    class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int j = 0;
            int n1 = 0;
            int n2 = 0;

            int[] nums1Copy = new int[m];
            for (int i = 0; i < m; i++)
                nums1Copy[i] = nums1[i];


            while (j < m + n)
            {
                if (n2 >= n || (n1 < m && nums1Copy[n1] < nums2[n2]))
                {
                    nums1[j] = nums1Copy[n1];
                    n1++;
                }
                else
                {
                    nums1[j] = nums2[n2];
                    n2++;
                }
                j++;
            }

        }
    }
}
