using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.DynamicProgrammingFibonacci.ClimbingStairs
{
    class ClimbingStairs
    { 
        //TAGS Google Amazon Microsoft
        //70. Climbing Stairs
        //You are climbing a staircase.It takes n steps to reach the top.
        //Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?
        /// <summary>
        /// In this problem we can use the same strategy like Fibonacci Number Pattern to accumulate all the 
        /// different ways to climb a staircase. Climb(0) = 0, Climb(1) = 1, Climb(2) = 2, Climb(3) = Climb(2) + Climb(1),
        /// Climb(4) = Climb(3) + Climb(2) ... Climb(n) = Climb(n-1) + Climb(n-2)
        /// create a for loop that simulates this same behavior and you will get your answer
        /// </summary>
        /// <param name="n">this is the fibonacci number we are trying to calculate, Fib(n)</param>
        /// <returns>the actual fibonacci number after performing all calculations</returns>
        public int ClimbStairs(int n)
        {
            if (n == 0)//if case 0. return 0
                return 0;
            if (n == 1)//if case 1. return 1, this is because of the fibonacci number definition
                return 1;
            if (n == 2)//Fib(2) = fib(1) + fib(0) = 1
                return 2;

            int step1 = 1;//set up fib 1
            int step2 = 2;//set up fib 2
            int numberOfSteps = 0;//set up number of stairs

            for (int i = 3; i <= n; i++)
            {
                numberOfSteps = step1 + step2;
                step1 = step2;
                step2 = numberOfSteps;
            }

            return numberOfSteps;
        }
    }
}
