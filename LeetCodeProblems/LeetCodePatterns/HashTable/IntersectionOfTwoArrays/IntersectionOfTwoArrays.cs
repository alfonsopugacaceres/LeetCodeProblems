using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.HashTable.IntersectionOfTwoArrays
{
    class IntersectionOfTwoArrays
    {
        //349. Intersection of Two Arrays
        //Given two integer arrays nums1 and nums2, return an array of their intersection.Each element in the result must be unique and you may return the result in any order.
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            int i = 0;
            int maxLen = (nums1.Length > nums2.Length) ? nums1.Length : nums2.Length;
            HashSet<int> n1 = new HashSet<int>();
            HashSet<int> n2 = new HashSet<int>();
            List<int> res = new List<int>();


            while (i < maxLen)
            {
                if (nums1.Length > i)
                    if (!n1.Contains(nums1[i]))
                        n1.Add(nums1[i]);
                if (nums2.Length > i)
                    if (!n2.Contains(nums2[i]))
                        n2.Add(nums2[i]);
                i++;
            }

            foreach (int num in n1)
                if (n2.Contains(num))
                    res.Add(num);

            return res.ToArray();
        }
    }
}
