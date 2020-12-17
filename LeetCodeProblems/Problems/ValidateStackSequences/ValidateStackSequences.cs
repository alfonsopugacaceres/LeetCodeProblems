using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.ValidateStackSequences
{
    public class ValidateStackSequences
    {
        public bool ValidateStackSeq(int[] pushed, int[] popped)
        {
            if (pushed.Length < 0 || popped.Length < 0 || pushed.Length > 1000 || popped.Length > 1000)
            {
                return false;
            }
            else
            {
                Stack<int> pastVals = new Stack<int>();
                int toPop = 0;
                for (int i = 0; i < pushed.Length; i++)
                {
                    pastVals.Push(pushed[i]);
                    while (pastVals.Count > 0 && pastVals.Peek() == popped[toPop])
                    {
                        pastVals.Pop();
                        toPop++;
                    }
                }
                if (toPop == pushed.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
