using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.MissingElementSortedArr
{
    public class MissingElementSortedArr
    {
        public int MissingElement(int[] nums, int k)
        {
            if (nums.Length < 0 || nums.Length > 50000)
            {
                return -1;
            }
            else
            {
                int missingCounter = 0;
                int previous = nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    while (previous + 1 != nums[i])
                    {
                        missingCounter++;
                        previous++;
                        if (missingCounter == k)
                        {
                            return previous;
                        }
                    }
                    if (missingCounter == k)
                    {
                        return previous;
                    }
                    else
                    {
                        previous = nums[i];
                    }
                }


                previous = nums[nums.Length - 1];
                while (k > missingCounter)
                {
                    missingCounter++;
                    previous++;
                }

                return previous;
            }
        }

        public int MissingElement2(int[] nums, int k)
        {
            //loop through the entire list, note we start from index 1
            for (int i = 1; i < nums.Length; i++)
            {
                //determine the difference between the previous + 1 and current
                int diff = nums[i] - (nums[i - 1] + 1);
                if (diff != 0) // if the difference is not 0, meaning not in a sequence
                {
                    if (k <= diff)//if we have enough mismatches
                        return nums[i - 1] + k;//return the previous mismatch plus the leftover addition of mismatches
                    else
                        k = k - diff;
                }
            }

            return nums[nums.Length - 1] + k;
        }

    }
}
