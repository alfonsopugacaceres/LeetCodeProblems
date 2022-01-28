using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems
{
    public class TwoSum
    {
        //1. Two Sum
        public TwoSum()
        {

        }


        public int[] Solve(int[] nums, int target)
        {
            if(nums.Length < 2 || nums.Length > 100000)
                return null;
            else if (target < -1000000000 || target > 1000000000)
                return null;

            else
            {
                //create a dictionary to store the numbers
                IDictionary<int, int> dict = new Dictionary<int, int>();
                //initiate a loop
                for (int i = 0; i < nums.Length; i++)
                {
                    //create a complement using the target and the current number
                    int complement = target - nums[i];

                    //check the dictionary to detrmine if there is a complement 
                    if (dict.ContainsKey(complement))
                    {
                        //if we find a complement we return the index of the complement and the current iteration
                        return new int[] { dict[complement], i };
                    }
                    else
                    {
                        //otherwise add the current value to the dictionary and its index
                        dict.Add(nums[i], i);
                    }
                }
                return null;

            }
            
        }

    }
}
