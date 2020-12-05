using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.DynamicFibonnacci
{
    public class DynamicFibonacci
    {
        public int CalculateFibonacci(int n)
        {
            if (n < 0 || n > 30)
            {
                return -1;
            }
            if (n <= 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 1;
            }
            else
            {
                int next = 0;
                int current = 1;
                int previous = 1;
                int i = 2;

                while (i < n)
                {
                    next = current + previous;
                    previous = current;
                    current = next;
                    i++;
                }

                return next;
            }
        }

        public int CalculateRecursiveFibonacci(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 1;
            }
            else
            {
                int target = n - 2;
                return FibonacciRecursion(1, 1, ref target);
            }
        }

        public int FibonacciRecursion(int current, int previous, ref int targetFibonacci)
        {
            int next = current + previous;
            targetFibonacci--;
            return (targetFibonacci == 0) ?  next : FibonacciRecursion(next, current, ref targetFibonacci);
        }
    }
}
