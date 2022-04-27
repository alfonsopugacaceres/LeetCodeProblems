using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.BitManipulation.HammingTheDistance
{
    class HammingTheDistance
    {
//        461. Hamming Distance
//        The Hamming distance between two integers is the number of positions at which the corresponding bits are different.
//Given two integers x and y, return the Hamming distance between them.
        public int HammingDistance1(int x, int y)
        {
            int ret = 0;

            while (x != 0 || y != 0)
            {

                if ((x & 1) != (y & 1))
                    ret++;
                x = x >> 1;
                y = y >> 1;
            }

            return ret;

        }
    }
}
