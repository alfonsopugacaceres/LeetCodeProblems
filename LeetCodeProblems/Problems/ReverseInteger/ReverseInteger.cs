using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.Problems.ReverseInteger
{
    public class ReverseInteger
    {
        public ReverseInteger()
        {

        }

        public int Solve(int input)
        {
            string inputString = input.ToString();
            string reverseString = string.Empty;

            if (input < 0)
                inputString = inputString.Remove(0, 1);

            for (int i = inputString.Length; i > 0; i--)
                reverseString += inputString.ElementAt(i - 1);

            if (input < 0)
                reverseString = "-" + reverseString;

            int ret = 0;
            try{
                if (!int.TryParse(reverseString, out ret))
                    return 0;
            }
            catch(Exception ex)
            {
                return 0;
            }
            return ret;
        }
    }
}
