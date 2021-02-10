using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.NumMajorityelement
{
    class NumMajorityElement
    {
        //1150. Check If a Number Is Majority Element in a Sorted Array
        public bool IsMajorityElement(int[] nums, int target)
        {
            double majorityFlag = nums.Length / 2;

            int incidence = 0;
            int i = 0;

            while(nums[i] != target)
            {
                i++;
            }

            while(i < nums.Length && nums[i] == target)
            {
                i++;
                incidence++;
            }

            return incidence > majorityFlag;
        }


        public bool IsMajorityElementBin(int[] nums, int target)
        {
            int firstIndex = firstOccur(nums, target);
            int plusNBy2Index = firstIndex + nums.Length / 2;

            if (plusNBy2Index < nums.Length
                && nums[plusNBy2Index] == target)
            {
                return true;
            }

            return false;
        }

        private int firstOccur(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length;
            while (low < high)
            {
                int mid = low + (high - low) / 2;
                if (nums[mid] < target) low = mid + 1;
                else if (nums[mid] >= target) high = mid;
            }
            return low;
        }
    }
}
