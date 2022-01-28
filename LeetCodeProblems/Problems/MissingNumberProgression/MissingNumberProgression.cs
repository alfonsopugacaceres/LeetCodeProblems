using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.MissingNumberProgression
{
    public class MissingNumberProgression
    {
        //1228. Missing Number In Arithmetic Progression
        public int MissingNumber(int[] arr)
        {
            //since the first number and the last number are always the same, and we are only missing one value,
            //we can deduce using the difference of the highest number, and the lowest number and then dividing it
            //by the length of the items to determine the step
            int diff = (arr[arr.Length - 1] - arr[0]) / arr.Length;

            int i = 0;
            while (i + 1 < arr.Length && arr[i + 1] - arr[i] == diff)
            {
                i++;
            }

            return arr[i] + diff;
        }
    }
}
