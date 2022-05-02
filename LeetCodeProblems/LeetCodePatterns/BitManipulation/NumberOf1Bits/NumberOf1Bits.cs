using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.BitManipulation.NumberOf1Bits
{
    class NumberOf1Bits
    {
        public int HammingWeight(uint n)
        {
            uint num = 0;

            while (n != 0)
            {
                num += n & 1;
                n = n >> 1;
            }

            return (int)num;
        }
    }
}
