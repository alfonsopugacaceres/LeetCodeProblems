using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.ValidateStackSequences
{
    public class ValidateStackSequences
    {
        //946. Validate Stack Sequences
        public bool ValidateStackSeq(int[] pushed, int[] popped)
        {
            //edge cases
            if (pushed.Length < 0 || popped.Length < 0 || pushed.Length > 1000 || popped.Length > 1000)
            {
                return false;
            }
            else
            {
                Stack<int> pastVals = new Stack<int>();//create a stack of past values
                int toPop = 0;//popping index
                for (int i = 0; i < pushed.Length; i++)//loop through the pushed array
                {
                    pastVals.Push(pushed[i]);//push the current push value into the stack

                    //while the stack has the current pop
                    //value at the top, pop the current value
                    //advance the counter to go to the next
                    //value to pop
                    while (pastVals.Count > 0 && pastVals.Peek() == popped[toPop])
                    {
                        pastVals.Pop();
                        toPop++;
                    }
                }
                if (toPop == pushed.Length)//if we popped as many as we pushed then the stack sequence is valid
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
