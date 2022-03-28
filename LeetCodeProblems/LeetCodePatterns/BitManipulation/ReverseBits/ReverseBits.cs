using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.BitManipulation.ReverseBits
{
    class ReverseBits
    {
        //Reverse bits of a given 32 bits unsigned integer.
        //Note:
        //Note that in some languages, such as Java, there is no unsigned integer type.In this case, both 
        //input and output will be given as a signed integer type. They should not affect your 
        //implementation, as the integer's internal binary representation is the same, whether it 
        //is signed or unsigned. n Java, the compiler represents the signed integers using 2's 
        //complement notation. Therefore, in Example 2 above, the input represents the signed 
        //integer -3 and the output represents the signed integer -1073741825.

        public uint ReverseBits1(uint n)
        {
            uint reverse = 0;
            int currentLoop = 0;
            while (n != 0)
            {
                uint current = n & 1;
                reverse = reverse | (current << (31 - currentLoop));
                n = n >> 1;
                currentLoop++;
            }

            return reverse;
        }
    }
}
