using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.FirstBadVersion
{
    public class FirstBadVersion
    {
        bool IsBadVersion(int n)
        {
            return true;
        }
        public int FirstBadVersion1(int n)
        {
            int left = 1;
            int right = n;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (IsBadVersion(mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }


    }
}
