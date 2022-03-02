using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.HammingDistance
{
    //461. Hamming Distance
    public class HammingDistance
    {
        public int HammingDistance1(int x, int y)
        {
            int result = 0;//result variable
            int i = 0;//counter
            while (i < 32)//integer has 32 bits
            {
                if ((x & 1) != (y & 1))//using the 1 as a mask, check if the first bit is a 1 for each number, if they do not match
                    result++;          //increment the result which is the number of different bits
                x = x >> 1;//do a bitwise shift to the right to change to the next bit
                y = y >> 1;//do a bitwise shift to the right to change to the next bit
                i++;//increment the counter
            }
            return result;//return the result
        }
    }
}
