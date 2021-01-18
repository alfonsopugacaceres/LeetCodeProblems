using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.FindNonOverlappingArray
{
    //1477. Find Two Non-overlapping Sub-arrays Each With Target Sum
    public class FindOverlappingArray
    {
        public int MinSumOfLengths(int[] arr, int target)
        {
            int i = 0;
            int j = 0;
            int currentSum = 0;
            Stack<int> s = new Stack<int>();

            while (j < arr.Length)
            {
                currentSum += arr[j];

                while(currentSum > target)
                {
                    currentSum -= arr[i];
                    i++;
                }

                if (currentSum == target)
                {
                    if (s.Count == 0)
                    {
                        s.Push(j - i + 1);
                    }
                    else
                    {
                        int lastPop = -1;
                        while (s.Count > 0 && s.Peek() > j - i + 1)
                        {
                            lastPop = s.Pop();
                        }
                        s.Push(j - i + 1);
                        if (s.Count < 2 && lastPop != -1)
                        {
                            s.Push(lastPop);
                        }

                    }
                }
                else if (currentSum > target)
                {
                    currentSum -= arr[i];
                    i++;
                }
            }

            if (s.Count < 2)
            {
                return -1;
            }
            else if (s.Count == 2)
            {
                int x = s.Pop();
                int y = s.Pop();
                return x + y;
            }
            return -1;
        }
    }
}
