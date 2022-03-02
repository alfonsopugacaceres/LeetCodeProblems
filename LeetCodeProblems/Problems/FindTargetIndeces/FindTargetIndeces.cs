using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.FindTargetIndeces
{
    public class FindTargetIndeces
    {
        public IList<int> TargetIndices(int[] nums, int target)
        {
            if (nums.Length < 1 || nums.Length > 100 || target > 100)//check for edge cases
                return null;
            else
            {
                IList<int> result = new List<int>();//create result list
                Array.Sort(nums);//sort array
                int i = 0;
                while (i < nums.Length)//loop through the array
                {
                    if (nums[i] > target)//since the array is sorted, if the current number is larger break out of the loop
                        break;
                    else if (nums[i] == target)//since the array is sorted, while the current number is the same as the target, add index to list
                        result.Add(i);
                    i++;//increment the counter variable to keep moving forward
                }
                return result;//return the result
            }
        }
        public IList<int> TargetIndices2(int[] nums, int target)
        {
            if (nums.Length < 1 || nums.Length > 100 || target > 100)//check for edge cases
                return null;
            else
            {
                IList<int> result = new List<int>();//create result list
                int belowTarget = 0;//counter variable for numbers below the target (this way we can keep track of the index)
                int atTarget = 0;//counter variable for numbers at the target

                for(int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] < target)//if the current number is below the target, increment the appropriate counter
                        belowTarget++;
                    else if (nums[i] == target)//if the current number is at the target increment the appropriate counter
                        atTarget++;
                }

                for(int j = 0; j < atTarget; j++)//loop through how many occurrences we had at the target, the start of the index is 
                    result.Add(belowTarget++);   //calculated by counting how many numbers were below the target

                return result;
            }
        }
    }
}
