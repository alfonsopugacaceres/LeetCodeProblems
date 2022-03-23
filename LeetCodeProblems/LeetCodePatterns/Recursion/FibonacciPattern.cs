using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Recursion
{
    class FibonacciPattern
    {
        public int RecursiveFibonacci(int n)
        {
            if (n <= 0)
                return 0;
            if (n == 1)
                return 1;
            else
                return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }

        public int RecursiveFibonacciMemo(int n)
        {
            IDictionary<int, int> fibMemo = new Dictionary<int, int>();
            fibMemo.Add(0, 0);
            fibMemo.Add(1, 1);
            return RecursiveFibonacciMemoHelper(n, fibMemo);
        }

        public int RecursiveFibonacciMemoHelper(int n, IDictionary<int, int> memo)
        {
            if (memo.ContainsKey(n))
                return memo[n];

            if (n < 0)
                return 0;

            int ret = RecursiveFibonacciMemoHelper(n - 1, memo) + RecursiveFibonacciMemoHelper(n - 2, memo);
            memo.Add(n, ret);
            return memo[ret];

        }
    }
}
