using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.TwoLessThanSumK
{
    public class TwoLessSumK
    {
        //1099. Two Sum Less Than K
        public int TwoSumLessThanK(int[] nums, int k)
        {
            Array.Sort(nums);//sort the array

            //create two pointers
            int left = 0;//left starts at the minimum values
            int right = nums.Length - 1;//right starts at the maximum values
            int max = -1;//max starts at the default answer, which is -1

            while(left < right)//while the left pointer is less than the right pointer
            {
                if(nums[left] + nums[right] < k)//check if the sum is less than k
                {
                    max = Math.Max(max, nums[left] + nums[right]);//calculate the maximum sum
                    left++;//increment left if we were lesser than k
                }
                else
                {
                    right--;//decrement the right if we went over k
                }
            }

            return max;

        }
    }
}
