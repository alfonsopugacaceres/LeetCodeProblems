using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.CountingBits
{
    public class CountingBits
    {

        public int[] CountBits2(int n)
        {

            int[] res = new int[n + 1];

            for (int i = 0; i <= n; i++)
            {
                res[i] = helper(i);
            }

            return res;
        }

        public int helper(int n)
        {
            int ret = 0;
            while (n != 0)
            {
                if ((n & 1) == 1)
                    ret++;
                n = n >> 1;
            }
            return ret;
        }

        public int[] CountBits(int n)
        {
            if (n < 0 || n > 100000) //check for edge cases
                return null;
            else
            {
                int[] result = new int[n+1];//create array

                for(int i = 0; i <= n; i++)
                    result[i] = recursiveCount(i);//call function for each number and place in corresponding slot
                return result;
            }
        }

        /// <summary>
        /// using a recursive function we can obtain the total number of 1s. First we check for the breakout case, which is a 0. A 0 has no 1s so we return 0.
        /// othersie, we take the current number with the bitwise representation of a 1, which is the lowest number that can have at least a single one, this
        /// effectively checks for the very first bit. Then we add the result of the recursive function after bitshifting right by 1, which discards the first bit
        /// this allows us to check the second bit. And then we continue until we get to 0.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        int recursiveCount(int num)
        {
            if (num == 0)
                return 0;
            else
                return num & 1 + recursiveCount(num >> 1); 
        }
    }
}
