using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.NumberOfGoodPair
{
    //1512. Number of Good Pairs
    public class NumberOfGoodPairs
    {
        public int NumIdenticalPairs(int[] nums)
        {
            if (nums == null || nums.Length < 1 || nums.Length > 100)
            {
                return -1;
            }
            int result = 0;
            int i = 0;
            int j = 1;

            while (i < nums.Length - 2)
            {
                if (j == nums.Length)
                {
                    i++;
                    j = i + 1;
                }
                if (nums[i] == nums[j])
                    result++;
                j++;
            }
            return result;
        }
        public int NumIdenticalPairs2(int[] nums)
        {
            if (nums == null || nums.Length < 1 || nums.Length > 100)
            {
                return -1;
            }
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int result = 0;
            //loop through the array of integers
            foreach (int i in nums)
            {
                //check if we have previously added the number
                if (!dict.ContainsKey(i))
                    dict.Add(i, 1);//if we have not added the number, add it to the dictionary with a number 1 to symbolize the number of pairs
                else
                    dict[i] = 1 + dict[i];//if the number was already in the dictionary, take the previous number of times it got added and add 1

                result += dict[i] - 1;//add to the result the total number of pairs - 1
                //we subtract 1 to get rid of the initial state of having 1, one number does not make a pair, we have to have more than 1 number to make a pair
            }

            return result;
        }
    }
}
