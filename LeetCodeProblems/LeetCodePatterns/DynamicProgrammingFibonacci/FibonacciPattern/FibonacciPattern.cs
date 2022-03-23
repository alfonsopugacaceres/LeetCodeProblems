using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.DynamicProgrammingFibonacci.FibonacciPattern
{
    class FibonacciPattern
    {
        //509. Fibonacci Number
        //The Fibonacci numbers, commonly denoted F(n) form a sequence, called the Fibonacci sequence, such that each number is the sum of the two preceding ones, 
        //starting from 0 and 1. That is,
        /// <summary>
        /// In this problem we can use the initial steps to create a recursive pattern. Notice, Fibonacci number 0 = 0
        /// Fibonacci number 1 = 1, Fibonacci number 2 = 2, Then Fib(3) = 3, Fib(4) = 5, Fib(6) = 8.
        /// The pattern is Fib(n) = Fib(n-1) + Fib(n-2)
        /// create a for loop that simulates this same behavior and you will get your answer
        /// </summary>
        /// <param name="n">this is the fibonacci number we are trying to calculate, Fib(n)</param>
        /// <returns>the actual fibonacci number after performing all calculations</returns>
        public int DynamicProgrammingFibonacci(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            else
            {
                int fib1 = 0;
                int fib2 = 1;
                int res = 0;

                for(int i = 2; i <= n; i++)
                {
                    res = fib1 + fib2;
                    fib1 = fib2;
                    fib2 = res;
                }

                return res;
            }
        }



    }
}
