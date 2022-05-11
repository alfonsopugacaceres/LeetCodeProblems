using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.PlusOne
{
    //66. Plus One
    //You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer.The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.
    //Increment the large integer by one and return the resulting array of digits.
    public class PlusOne
    {
        public int[] PlusOne1(int[] digits)
        {
            List<int> list = new List<int>();

            int carryOver = 1;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int currentNumber = digits[i] + carryOver;
                if (currentNumber != 0 && currentNumber % 10 == 0)
                {
                    currentNumber = currentNumber % 10;
                    carryOver = 1;
                }
                else
                    carryOver = 0;

                list.Add(currentNumber);
            }

            if (carryOver > 0)
                list.Add(carryOver);

            list.Reverse();
            return list.ToArray();
        }
    }
}
