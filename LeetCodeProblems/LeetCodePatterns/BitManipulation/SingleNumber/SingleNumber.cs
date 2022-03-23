using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.BitManipulation.SingleNumber
{
    class SingleNumber
    {
        //TAGS Google Amazon Microsoft
        //136. Single Number
        //Given a non-empty array of integers nums, every element appears twice except for one.Find that single one.
        //You must implement a solution with a linear runtime complexity and use only constant extra space.

        /// <summary>
        /// This answer leverages a bitwise concepts. Using XOR (Exclusive OR) we can XOR all numbers onto the same
        /// return variable, this allows us to get a number in bits, like 100, then XOR it with itself 100 XOR 100 = 000
        /// which causes all the bits to blank out, if a number does not have a duplicate, then the number will be leftover in the
        /// variable a. Return a and you have your answer
        /// </summary>
        /// <param name="nums">input array</param>
        /// <returns>number that was not duplicates</returns>

        public int SingleNumber2(int[] nums)
        {
            int a = 0;
            foreach (int i in nums)
            {
                a ^= i;
            }
            return a;
        }
    }
}
