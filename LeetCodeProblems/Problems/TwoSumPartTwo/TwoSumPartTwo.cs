using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.TwoSumPartTwo
{
    public class TwoSumPartTwo
    {
        public int[] TwoSum(int[] numbers, int target)
        {

            //create a variable for start
            int i = 0;
            //create a variable for end
            int j = numbers.Length - 1;

            //loop while the start is less than the end
            while (i < j)
            {
                //add up the numbers
                int sum = numbers[i] + numbers[j];
                //check if we found the target
                if (sum == target)
                {
                    //if found, return answer
                    return new int[] { i + 1, j + 1 };
                }
                //if the sum is greter than the target
                else if (sum > target)
                {
                    //reduce the maximum
                    j--;
                }
                else
                {
                    //if the number is lower than the target
                    //increase the minimum
                    i++;
                }
            }
            return null;
        }
    }
}
