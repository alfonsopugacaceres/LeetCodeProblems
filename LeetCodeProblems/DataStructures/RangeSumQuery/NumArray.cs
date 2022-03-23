using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GoogleRecommended.GooglePatterns.RangeSumQuery
{
    public class NumArray
    {
        //Given an integer array nums, handle multiple queries of the following type:
        //Calculate the sum of the elements of nums between indices left and right inclusive where left <= right.
        //Implement the NumArray class:
        //NumArray(int[] nums) Initializes the object with the integer array nums.
        //int sumRange(int left, int right) Returns the sum of the elements of nums between indices left and right inclusive(i.e.nums[left] + nums[left + 1] + ... + nums[right]).

        private int[] _nums;

        public NumArray(int[] nums)
        {
            _nums = new int[nums.Length + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                _nums[i + 1] = nums[i] + _nums[i];
            }
        }

        public int SumRange(int left, int right)
        {
            if (left < 0 || right > _nums.Length)
                return -1;

            return _nums[right + 1] - _nums[left];
        }
    }
}
