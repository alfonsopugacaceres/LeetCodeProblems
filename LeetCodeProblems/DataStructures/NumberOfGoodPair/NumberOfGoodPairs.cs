using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.NumberOfGoodPair
{
    //1512. Number of Good Pairs
    public class NumberOfGoodPairs
    {
        /// <summary>
        /// This algorith has computational complexity of O(n) and space complexity of O(2n) -> O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int NumIdenticalPairs(int[] nums)
        {
            if (nums == null || nums.Length < 1 || nums.Length > 100)//calculate the edge case
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
                                          //please note the relationship between pairs, when you have 0 numbers or 1 number you have 0 pairs,
                                          //when you have 2 numbers you have 1 pair, 3 numebers 3 pairs, 4 numbers you have 6 pairs, when you have 5 numbers 
                                          //you have 10 pairs. Pasically 1 + 2 + 3 + 4 + 5. That is why we add dictionary + 1 to accumulate the pairs

                result += dict[i] - 1;//add to the result the total number of pairs - 1
                //we subtract 1 to get rid of the initial state of having 1, one number does not make a pair, we have to have more than 1 number to make a pair
            }

            return result;
        }
    }
}
