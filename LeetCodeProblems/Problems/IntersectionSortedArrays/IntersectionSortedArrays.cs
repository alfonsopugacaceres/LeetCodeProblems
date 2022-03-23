using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.IntersectionSortedArrays
{
    public class IntersectionSortedArrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (!set1.Contains(nums1[i]))
                    set1.Add(nums1[i]);
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                if (!set2.Contains(nums2[i]))
                    set2.Add(nums2[i]);
            }

            List<int> ret = new List<int>();

            foreach (int x in set1)
            {
                if (set2.Contains(x))
                    ret.Add(x);
            }

            return ret.ToArray();
        }

    }
}
