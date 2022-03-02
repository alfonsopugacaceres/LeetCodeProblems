using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.NthFibonacciNumber
{
    public class NthFibonacci
    {
        int[] fibonacciNumbers = null; 
        public NthFibonacci(){
            fibonacciNumbers = new int[38];//memoized fibonnaci array
            fibonacciNumbers[0] = 0;
            fibonacciNumbers[1] = 1;
            fibonacciNumbers[2] = 1;
            for (int i = 3; i < 38; i++)//using this simple loop we can get all fibonnaci numbers up until 38
                fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2] + fibonacciNumbers[i - 3];

        }

        public int Tribonacci(int n)
        {
            if (n < 0 || n > 37)//check for edge case
                return -1;
            else
                return fibonacciNumbers[n];//return the memoized fibonacci number
        }

        public int Tribonnacci2(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1 || n == 2)
                return 1;
            else
            {
                int fib1 = 0;
                int fib2 = 1;
                int fib3 = 1;
                int sum = 0;

                for(int i = 3; i <= n; i++)
                {
                    sum = fib1 + fib2 + fib3;
                    fib1 = fib2;
                    fib2 = fib3;
                    fib3 = sum;
                }

                return fib3;

            }
        }

    }
}
