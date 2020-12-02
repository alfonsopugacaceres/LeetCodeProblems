using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems
{
    public class MinimumSizeSubarraySum
    {

        //this problem is a sliding window problem
        public int MinSubArrayLen(int s, int[] nums)
        {
            bool foundResponse = false;
            int minLenResponse = int.MaxValue;
            int movingPointer = 0;
            int sum = 0;

            if(nums.Length <= 0)
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    sum += nums[i];
                    while (sum >= s)//sliding window condition, we found a sum of integers which is greater than or equal to the target s
                    {
                        foundResponse = true;
                        //We found a set of numbers that satisfies the condition, therefore store the current solution.
                        //Since we are trying to find the minimum length, we compare the moving pointer with i + 1 (to simulate size rather than index)
                        //and we store it for future comparisons
                        minLenResponse = (minLenResponse > i + 1 - movingPointer) ? i + 1 - movingPointer : minLenResponse;

                        //When we slide the window forward, by changing the pointer, we must subtract the value that's no longer under consideration
                        //aka nums[movingPointer]
                        sum = sum - nums[movingPointer];

                        //this line actually moves the pointer forward 
                        movingPointer++;
                    }

                }

                return (foundResponse) ? minLenResponse : 0;
            }
        }

    }
}
