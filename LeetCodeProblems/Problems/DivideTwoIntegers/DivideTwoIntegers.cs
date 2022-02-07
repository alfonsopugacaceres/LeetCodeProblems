using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.DivideTwoIntegers
{
    public class DivideTwoIntegers
    {
        public int Divide(int dividend, int divisor)
        {
            int result = 0;
            int negativeCount = 0;
            int localDividend = dividend;
            int localDivisor = divisor;


            if (localDividend > int.MaxValue)
                return int.MaxValue;
            else if(localDividend < 0)
            {
                negativeCount++;
                if (localDividend == int.MinValue)
                    localDividend = int.MaxValue;
                else
                    localDividend = -localDividend;
            }


            if (localDivisor >= int.MaxValue)
                return int.MaxValue;
            else if (localDivisor < 0)
            {
                negativeCount++;
                if (localDivisor == int.MinValue)
                    localDivisor = int.MaxValue;
                else
                    localDivisor = -localDivisor;
            }
            Console.WriteLine("localDividend {0}", localDividend);
            Console.WriteLine("localdivisor {0}", localDivisor);
            Console.WriteLine("negativeCount {0}", negativeCount);

            while (localDividend >= localDivisor)
            {
                result++;
                localDividend -= localDivisor;
            }

            if (negativeCount == 1)
                return (dividend == int.MinValue) ? -result - 1 : -result;
            else
                return result;
        }
    }
}
